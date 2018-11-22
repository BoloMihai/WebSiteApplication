STEPS TO RUN THE APPLICATION LOCALLY:
1. Download and install "sql server 2017" and sql "server management studio 2017 (S.S.M.S.2017)" (set login:"sa" ; set password:"angel123") on your personal machine.

2. Download this "WebSiteApplication" project from GitHub. extract its containg files on your personal machine. Open the extracted "WebSiteApplication-master" folder and find the "CUST.bak" file. Open S.S.M.S.2017 and use it to restore the database from that "CUST.bak" file into sql server 2017.

3. Download and install "visual studio 2017 (v.s.2017)" (install IIS express).

4. Open WebSiteApp folder and double-click on "WebSiteApp.sln" file (using v.s.2017 as default program from the listed programs).
(now the WebSiteApp project will be loaded into v.s.2017)

5. With WebSiteApp project loaded into v.s.2017, go to "Solution Explorer" on the right side of v.s.2017 and expand WebSiteApp project region from there. After that right-click on "WebPageApp.aspx" file and choose "Set As Start Page".

6. With WebPageApp.aspx file set as starting page of the WebSiteApp project press the "START" green button on the top side of v.s.2017 to run the WebSiteApp project. 
(now the WebSiteApp application will start in your browser)

7. From the browser complete the two empty textBoxes with their according texts (providing Name and Email).

8. From the browser press any of the two buttons placed below the textBoxes (pressing InsertOrUpdate or Delete).

9. From the browser follow the notifications displayed below each pressed button to poper interact with WebSiteApp application (displaying success or failure messages).


SAMPLES OF THE WEB SERVICE REQUEST
http://localhost:/WebServiceApp.asmx
http://localhost:/WebServiceApp.asmx?op=InsertUpdateCustomer
http://localhost:/WebServiceApp.asmx?op=DeleteCustomer
