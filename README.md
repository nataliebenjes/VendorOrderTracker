# Vendor Order Tracker

### By Natalie Benjes

## What Is This?

 Pierre's bakery is expanding, and he needs a reliable way to track his vendors and their orders. To meet his requirements, we have built the "Vendor and Order Tracker" using the Model-View-Controller (MVC) architecture. This web application will assist Pierre in managing his business relationships and orders efficiently.

## Technologies Used
1. C# and .NET Core

2. Razor: Razor syntax is used for the views, allowing seamless integration of C# code within HTML pages, creating dynamic and interactive web pages.

3. This application follows the MVC pattern, promoting separation of concerns and making it easier to manage and extend the codebase.

## Features
1. Homepage - Welcome Pierre: Upon accessing the application at the root path (localhost:5000/), Pierre will be greeted with a welcoming splash page. This page will provide him with a link to the Vendors page, where he can view and manage his vendors.

2. Vendors Page: This page will display a list of all registered vendors. For each vendor, Pierre will be able to click their name and navigate to a dedicated page that showcases all the orders associated with that particular vendor.

3. Create a New Vendor: On the Vendors page, Pierre will find a form to create a new vendor. When he fills out the necessary details and submits the form, a new Vendor object will be created and added to the list of vendors, enabling Pierre to keep track of all his business relationships.

4. Vendor Orders Page: When Pierre clicks on a vendor's name, he will be directed to a new page that displays all orders associated with that vendor. This view will help him monitor the orders placed by each vendor with ease.

5. Create a New Order: To add a new order for a specific vendor, Pierre can use the "Create New Order" form accessible via a link on the Vendor Orders page. The URL for this form will follow a pattern like "/vendors/1/orders/new", where "1" represents the vendor's unique ID.



## How To Run This Project

1. Clone this repo: `git clone https://github.com/nataliebenjes/VendorOrderTracker/blob/master/VendorOrderTracker/models/Vendor.cs`
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory `cd vendor-order-tracker`. 
3. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Contribution

We welcome contributions to make the "Vendor and Order Tracker" even better! If you find any issues or have suggestions for enhancements, please feel free to open an issue or submit a pull request on our GitHub repository.

Let's work together to provide Pierre with a robust and user-friendly tool for tracking his vendors and orders effectively!

## Known Bugs


## License

MIT License

Copyright (c) (2023) Natalie Benjes

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.