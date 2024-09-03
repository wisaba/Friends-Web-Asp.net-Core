Friend Management Web Application

Features

    MVC Architecture: The application follows the Model-View-Controller (MVC) design pattern.
    Friend Class: A Friend class that contains the friend's name, number, and photo.
    FriendsController: A controller named FriendsController that performs the following operations:
        Display a list of friends at /Friends/List
        Display details of a specific friend at /Friends/detail/{id}
        Add a new friend
    New Friend Registration: A form to register a new friend, including their name, number, and a link to their image.
    Partial View: A footer that is loaded as a partial view, displaying the website name and a link to the friends' page.
    Middleware: Custom middleware to display the total number of registered friends as a plain number at /total-friends.
    Static Friend List: A static list of the Friend class initialized with 10 friends for demonstration purposes.
![12 06 2024_02 33 12_REC](https://github.com/wisaba/Friends-Web-Asp.net-Core/assets/98482827/530e60ca-84f2-4565-974c-bb48e7f2c067)

![12 06 2024_02 34 12_REC](https://github.com/wisaba/Friends-Web-Asp.net-Core/assets/98482827/81fe77b4-21e8-4d1b-8fd6-546ddbe8347c)
here user can see friends' list
