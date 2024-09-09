window.onload = function() {

    if (document.title == "Main") {
        const post = document.getElementById('post');
        const update = document.getElementById('update');
        const Delete = document.getElementById('Delete');
        const tabela = document.getElementById('tableMain');
        
        axios.get(`http://localhost:3000/usuarios`)
        .then(response => {
            preencherTabela(response.data);
        })
        .catch(error =>{
            alert(error)
        });

        post.onclick = function() {
            window.location.href = "post.html"
        }

        Delete.onclick = function() {
            const checkboxes = document.querySelectorAll('table input[type="checkbox"]');
            const isAnyChecked = Array.from(checkboxes).some(checkbox => checkbox.checked);
            const usuarios = [];

            checkboxes.forEach((checkbox, index) => {
                if(checkbox.checked)
                {
                    usuarios.push({
                        id: tabela.rows[index + 1].cells[0].innerText
                    });
                }
            });

            if (isAnyChecked) {
                axios.delete(`http://localhost:3000/usuarios/many`, { data: usuarios })
                    .then(response => {
                       window.location.href = "index.html";
                    })
                    .catch(error =>{
                        alert(error)
                    });
            }
        }
    }
    else if (document.title == "Post") {
        
        const nome = document.getElementById('nome');
        const cpf = document.getElementById('cpf');
        const email = document.getElementById('email');
        const cadastrar = document.getElementById('cadastrar');


        cadastrar.onclick = function() {
            if (nome.value) {
                if (cpf.value) {
                    if (email.value) {
                        axios.post(`http://localhost:3000/usuarios`, {
                            nome: nome.value,
                            cpf: cpf.value,
                            email: email.value
                        })
                        .then(response => {
                           window.location.href = "index.html";
                        })
                        .catch(error =>{
                            alert(error)
                        });
                    }
                    else {
                        alert("Campo email é obrigatório");
                        email.focus();
                    }
                }
                else {
                    alert("Campo cpf é obrigatório");
                    cpf.focus();
                }
            }
            else {
                alert("Campo nome é obrigatório");
                nome.focus();
            }
        }
    }

    function preencherTabela(dados) {
        const tabela = document.getElementById('tableMain');
      
        if (tabela) {
          tabela.innerHTML = '';
          
            const novaLinha = tabela.insertRow();
            const cellId = novaLinha.insertCell(0);
            const cellNome = novaLinha.insertCell(1);
            const cellCpf = novaLinha.insertCell(2);
            const cellEmail = novaLinha.insertCell(3);

            cellId.textContent = "ID";
            cellNome.textContent = "Nome";
            cellCpf.textContent = "CPF";
            cellEmail.textContent = "Email";
            
            dados.forEach(item => {
                const novaLinha = tabela.insertRow();
                const cellId = novaLinha.insertCell(0);
                const cellNome = novaLinha.insertCell(1);
                const cellCpf = novaLinha.insertCell(2);
                const cellEmail = novaLinha.insertCell(3);
                const checkBox = novaLinha.insertCell(4);
        
                cellId.textContent = item.id;
                cellNome.textContent = item.nome;
                cellCpf.textContent = item.cpf;
                cellEmail.textContent = item.email;
                checkBox.innerHTML = '<input type="checkbox" id="checkbox">';
          });
        } else {
            console.error('Table element with ID "tableMain" not found.');
        }
    }
}