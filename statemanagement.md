# StateManagement in Asp.Net
State management is a technique that is used to manage a state of an object on different request. 
It is very important to manage state in any web application. There are two types of state management systems in ASPNET.

| Client-Side State Management  | Server-Side State Management | 
 |:--- |:-----|
 |Client-Side| Server-Side |
 | View State |Session State-->In-proc,State server,Sql server |
 | Hidden field | Application State|
 | Cookies-->Persistent & Non-Persistent Cookie | 
 | Control State |  
 | Query Strings |  
 
 
 # Client-Side StateManagement
 *  **View state** : is the method that the ASP.NET page framework uses to preserve page and control values between round trips.
 *  **Hidden field** : is used for storing small amounts of data on the client side. In most simple words it's just a container of some
    objects but their result is not rendered on our web browser. It is invisible in the browser.
 *  **Cookies** : is a small piece of information stored on the client machine. This file is located on client machines path.  
    Its is used to store user preference information like Username, Password,City and PhoneNo etc on client machines.   
 *  **Control State** : Used for enabling the View State Property,It defines a custom view and it Can't be modified,It can Accessed directly or disabled. 
 *  **Query String** : A query string is one of the techniques in Web applications to send data from one webform to another through the URL.
 
 # Server-Side StateManagement
 * **Session State** : Enables you to store and retrieve values for a user as the user navigates ASP.NET pages in a Web application.<br />
  **a**, **InProc mode:** which stores session state in memory on the Web server. This is the default.<br />
  **b**, **StateServer mode:** which stores session state in a separate process called the ASP.NET state service. 
          This ensures that session state is preserved if the Web application is restarted and also makes session
          state available to multiple Web servers in a Web farm.<br />
  **c**, **SQLServer** : mode stores session state in a SQL Server database. This ensures that session state is preserved 
          if the Web application is restarted and also makes session state available to multiple Web servers in a Web farm.<br />
 * **Application State** : which stores variables that can be accessed by all users of an ASP.NET application.
   
