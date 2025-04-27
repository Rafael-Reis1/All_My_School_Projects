-- CreateTable
CREATE TABLE "imoveis" (
    "id_imovel" TEXT NOT NULL PRIMARY KEY,
    "cep" TEXT NOT NULL,
    "logradouro" TEXT NOT NULL,
    "numero" INTEGER NOT NULL,
    "bairro" TEXT NOT NULL,
    "localidade" TEXT NOT NULL,
    "estado" TEXT NOT NULL,
    "uf" TEXT NOT NULL,
    "preco" REAL NOT NULL,
    "proprietario" TEXT NOT NULL,
    "disponivel" BOOLEAN NOT NULL,
    CONSTRAINT "imoveis_proprietario_fkey" FOREIGN KEY ("proprietario") REFERENCES "usuarios" ("id_usuario") ON DELETE RESTRICT ON UPDATE CASCADE
);

-- CreateTable
CREATE TABLE "reservas" (
    "id_reserva" TEXT NOT NULL PRIMARY KEY,
    "id_imovel" TEXT NOT NULL,
    "cliente" TEXT NOT NULL,
    "totalDias" TEXT NOT NULL,
    "totalPreco" REAL NOT NULL,
    "data_entrada" DATETIME NOT NULL,
    "data_saida" DATETIME NOT NULL,
    CONSTRAINT "reservas_id_imovel_fkey" FOREIGN KEY ("id_imovel") REFERENCES "imoveis" ("id_imovel") ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT "reservas_cliente_fkey" FOREIGN KEY ("cliente") REFERENCES "usuarios" ("id_usuario") ON DELETE RESTRICT ON UPDATE CASCADE
);

-- CreateTable
CREATE TABLE "usuarios" (
    "id_usuario" TEXT NOT NULL PRIMARY KEY,
    "email" TEXT NOT NULL,
    "senha" TEXT NOT NULL,
    "nome" TEXT NOT NULL
);

-- CreateIndex
CREATE UNIQUE INDEX "usuarios_email_key" ON "usuarios"("email");
