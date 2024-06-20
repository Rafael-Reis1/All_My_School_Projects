package com.mycompany.bookmanager.MainMenu;

import com.mycompany.bookmanager.Books.Books;
import com.mycompany.bookmanager.Layout.BooksLayout;
import com.mycompany.bookmanager.Layout.Main;
import java.util.ArrayList;
import java.util.List;

public class MainClass {
    public static List<Books> books = new ArrayList<Books>();
    public static List<BooksLayout> booksLayoutList  = new ArrayList<BooksLayout>();
    private static int ID = 1;
    public static int indexBook;
    public static int openEdit = 0;
    
    
    public static void addBook(String titulo, String autor)
    {
        Books bookAdd = new Books();
        bookAdd.setTitulo(titulo);
        bookAdd.setAutor(autor);
        bookAdd.setID(ID);
        books.add(bookAdd);
        BooksLayout booksLayout = new BooksLayout();
        booksLayout.jLabelTitulo.setText(titulo);
        booksLayout.jLabelAutor.setText(autor);
        booksLayout.jLabelID.setText(String.valueOf(ID));
        booksLayoutList.add(booksLayout);
        Main.AddPanel(booksLayout);
        ID++;
    }
}