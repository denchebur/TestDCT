   M S B A M L   `   `   `  ����B  >TestDCT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TestDCTTestDCT  5      7 clr-namespace:TestDCT.ViewModelsTestDCT.ViewModels  5          TestDCT.ConverterPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:TestDCT     5      6	viewModel clr-namespace:TestDCT.ViewModels     5        N� Title$  ConverterPage��5
      .��5      �� .+�5   
   �� -   5        $��
assetsList��5      $	��350��6%    �� Left$ 10��62   
 �� Top$ 70��6C   $	��241��6S   $��Center=�5      $��Center=�60    � DataContext 5      '   !TestDCT.ViewModels.AssetViewModel  5       �� View 5      �� 5      .P�5      ��  �� Width$
 auto��6%   $��Symbol��62    �� DisplayMemberBinding 6B   �� *symbol+�� 5      $
 auto��6%   $��
Asset name��62    6F   �� *name+�� 5      $ 35��6%   $
��Rank��60    6>   �� *rank+5      5      �� 5   
   -   5         ��Name$ textBox��5      $��23��6#   $ 12��6/    �� TextWrapping$
 Wrap=�6@   $�� ��6T   $ 26��5      $	��190��6"   $
��Left=�6.   $��Center=�6I   �� 5   
   -   5        	 ��Name$	 searchButton��5      $��Search��6'   $��23��68   $	 207��6D   $ 26��5      $��44��6!   $
��Left=�6,   $��Center=�6G   5      �� 5   
   -   5        
 ��Name$
 assetsList2��5      $	��350��6(   $	 338��65   $ 70��6G   $	��241��6W   $
��Left=�5    ?   $��Center=�6Z    5!        5"       5$      �� 5%      .P�5&      �� $
 auto��6%   $��Symbol��62    6B   �� *symbol+�� 5'      $
 auto��6%   $��
Asset name��62    6F   �� *name+�� 5(      $ 35��6%   $
��Rank��60    6>   �� *rank+5)      5+      �� 5,   
   -   5        $ textBox2��5,      $��23��6$   $	 340��60   $
 Wrap=�6B   $�� ��6V   $ 26��5-      $	��190��6   $
��Left=�6)   $��Center=�6D   �� 5.   
   -   5        $	 searchButton2��5.      $��Search��6(   $��23��69   $	 535��6E   $ 26��5/      $��44��6   $
��Left=�50   )   $��Center=�6D   �� 51   
   -   5         ��Name$ label��51      $��TO ->��6   $��26��6/   $	 264��6;   $	 212��6M   $��62��6^   52      53      