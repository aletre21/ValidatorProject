   M S B A M L   `   `   `  ����K  GValidatorProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ValidatorProjectValidatorProject  5   	   !    ValidatorProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0localclr-namespace:ValidatorProject     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��525��5   	   $	��350��5	   	    � DataContext 5
   	   ��    Locator �� Source# [   �� Path$
 Main�.��5      � 
�������.+�5   
   �� -   5         ��Name$ 	LoginText��5      $	��121��5      $��23��5      $��
54,167,0,0q�5      $
��Left=�5      $	��Top=�5       �� TextWrapping$
 Wrap=�5      ��5      �� *WrittenLogin+ �� UpdateSourceTrigger$ PropertyChanged=�5      G� 5   
   -   5         G�Name$ PasswordText��5      $	��120��5      $��23��5      $��336,167,0,0q�5      $
��Left=�5      $	��Top=�5      �� 5   
   -   5         ��Name$ buttonLogin��5      $	��120��5       $��
55,195,0,0q�5!      $
��Left=�5"      $	��Top=�5#      $��Check��5%      ��5$      �� *
CheckLogin+5%      �� 5&   
   -   5        $ buttonPassword��5&      $	��120��5'      $��336,195,0,0q�5(      $
��Left=�5)      $	��Top=�5*      $��Check��5-      ��5+      �� $ CheckPassword���5,      �� 	 �� ElementName$	 PasswordText��5-      �� 51   
   -   5        
 ��Name$
 PasswordInfo��51      $	��224��52      $��95��53      $��
284,39,9,0q�54      $��Center=�55      $	��Top=�56      $��Center=�57      ��58      �� *IsPasswordValid+$ PropertyChanged=��� 5:   
   -   5        $
 Login��5:      $��
93,134,0,0q�5;      $
��Left=�5<      $	��Top=�5=      $��Login��5>      �� 5?   
   -   5        $
 Password��5?      $��367,134,0,0q�5@      $
��Left=�5A      $	��Top=�5B      $��Password��5C      �� 5D   
   -   5        $
 	LoginInfo��5D      $	��224��5E      $��95��5F      $��
2,39,291,0q�5G      $��Center=�5H      $	��Top=�5I      $��Center=�5J      ��5K      �� *IsLoginValid+$ PropertyChanged=�5N      5O      