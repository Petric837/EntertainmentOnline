<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="TechnicalDoc.aspx.cs" Inherits="EntertainmentOnline.TechnicalDoc" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1>How to use this website</h1> 
        <p>In order to do anything on this website, besides view the rentals, you must log into an account.
           You can create an account by clicking "Sign Up" or log into an existing account by clicking "Log In".
           After logging in, you can add rentals to your shopping cart.  The number of items in your cart will 
           show up next to the shopping cart button in the header.  When you are ready to check out, you can click 
           the shopping cart to view your cart and then click the "Checkout" button to complete your order.  If you 
           are a special admin member, you can also access the "Manage Users" and "Manage Rentals" pages where you 
           view all records in the databases, as well as add, edit, and delete them.
        </p> <br />
        <h1>Technical Document</h1>
        <p>The main pages of the website are the home page, shopping cart page, manage users page, and manage rentals page.  
           All of the navigation of the website is ran through the header of the website.  Accounts are added to the
           database after users fill out a form of their information.  The form information is used to add a record to 
           the database.  The users don’t have to perform any procedure to view records on movies and games.  The records 
           will automatically display on the screen as soon as the user loads the page.  However, they can perform queries 
           by selecting to view strictly movies or strictly videogames and searching records by title where they would simply 
           type the title they’re looking for in a search bar.
        </p>
        <p>
            The database holds all info on user accounts and movie and videogame records.  The data is split among two table; 
            one for the user accounts and one for movies and videogames.  The user accounts have data fields for username, 
            password, address, phone number, credit card type, credit card number, and whether the account is regular or 
            administrative.  The account’s username is used as a primary key.  The movies and videogames have data fields 
            for whether it’s a movie or a videogame, title, genre, date released, price, review score, and an ID to use as 
            a primary key.  These data fields allow the user to be able to search for just movies or just games depending on 
            what they’re looking for or even search for a movie or game by title.
        </p>
        <p>
            There are two types of user accounts: regular and administrative.  Regular accounts can look through the database 
            records for movies and games, order and checkout whatever they want, and edit their own account.  Administrative 
            accounts are able to add, edit, and delete records from the database as well as edit or delete any account.  
            Overall, administrators have full control over data in the database.  Users that are not signed in to an account 
            will not be able to add any movies or videogames to a cart nor checkout.
        </p>
  
    </div>

</asp:Content>
