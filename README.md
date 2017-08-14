# Dynamics 365 for Finance and Operations Development Cookbook - Fourth Edition
This is the code repository for [Dynamics 365 for Finance and Operations Development Cookbook - Fourth Edition](https://www.packtpub.com/application-development/dynamics-365-operations-development-cookbook-fourth-edition?utm_source=github&utm_medium=repository&utm_campaign=9781786468864), published by [Packt](https://www.packtpub.com/?utm_source=github). It contains all the supporting project files necessary to work through the book from start to finish.
## About the Book
Microsoft Dynamics 365 for Finance and Operations has a lot to offer developers. It allows them to customize and tailor their implementations to meet their organization’s needs. This Development Cookbook will help you manage your company or customer ERP information and operations efficiently. We start off by exploring the concept of data manipulation in Dynamics 365 for Operations. This will also help you build scripts to assist data migration, and show you how to organize data in forms. You will learn how to create custom lookups using Application Object Tree forms and generate them dynamically.


## Instructions and Navigation
All of the code is organized into folders. Each folder starts with a number followed by the application name. For example, Chapter02.



The code will look like the following:
```
[FormDataSourceEventHandler(formDataSourceStr(CustGroup,
 CustGroup), FormDataSourceEventType::Written)]
 public void CustGroup_OnWritten(FormDataSource sender,
 FormDataSourceEventArgs e)
 {
 this.numberSeqFormHandler().formMethodDataSourceWrite();
 }
```

All the coding examples were performed in a Microsoft Azure-hosted Microsoft Dynamics
365 for Financial and Operations environment. The following list of software from the
virtual image was used in this book:
* Microsoft Dynamics 365 for Financial and Operations (Update 6)
* Microsoft Visual studio 2015
* Microsoft Windows Server 2015 Enterprise
* Microsoft SQL Server 2016
* Microsoft Power BI
* Microsoft Office Excel 2015
* Microsoft Office Word 2015
* Microsoft Internet Explorer
* Windows Notepad
Although all the recipes have been tested on the previously-mentioned software, they may
work on older or newer software versions with minor code adjustments. As Microsoft is
continuously evolving on Dynamics 365 for Financial and Operations, we might see some
differences while using the same code in older or newer updates of application. Stick to the
concept and customize or extend the application.

## Related Products
* [Extending Microsoft Dynamics 365 for Operations Cookbook](https://www.packtpub.com/application-development/extending-microsoft-dynamics-365-operations-cookbook?utm_source=github&utm_medium=repository&utm_campaign=9781786467133)

* [Implementing Microsoft Dynamics 365 for Operations](https://www.packtpub.com/big-data-and-business-intelligence/implementing-microsoft-dynamics-365-operations?utm_source=github&utm_medium=repository&utm_campaign=9781787283336)

* [BPEL Cookbook: Best Practices for SOA-based integration and composite applications development](https://www.packtpub.com/application-development/bpel-cookbook-best-practices-soa-based-integration-and-composite-application?utm_source=github&utm_medium=repository&utm_campaign=9781904811336)

### Suggestions and Feedback
[Click here](https://docs.google.com/forms/d/e/1FAIpQLSe5qwunkGf6PUvzPirPDtuy1Du5Rlzew23UBp2S-P3wB-GcwQ/viewform) if you have any feedback or suggestions.
