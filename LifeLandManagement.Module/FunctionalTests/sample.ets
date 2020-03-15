;#DropDB LifeLandManagementEasyTest

#Application LifeLandManagementWin
#Application LifeLandManagementWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef LifeLandManagementWin

*Action About...
 
*Action OK

#EndIf

#IfDef LifeLandManagementWeb
*Action Navigation(My Details)
#EndIf
