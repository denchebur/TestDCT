   M S B A M L   `   `   `  ����B  >TestDCT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TestDCTTestDCT  5      7 clr-namespace:TestDCT.ViewModelsTestDCT.ViewModels  5          TestDCT.MainPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:TestDCT     5      6	viewModel clr-namespace:TestDCT.ViewModels     5        N� Title$  MainPage��5	      $	��326��6   .��5      �� $��	0,0,0,-93q�6   .+�5   
   �� -   5        $��
assetsList��5       �� Left$ 10��6D   
 �� Top$ 65��6U   $	��291��6e   $��Center=�6q   $	��241��6�   $	��Top=�6�   ��6%   �� *Assets+ � DataContext 5      '   !TestDCT.ViewModels.AssetViewModel  5       �� View 5      �� 5      .P�5      ��  �� Width$
 auto��6%   $��	Price USD��62    �� DisplayMemberBinding 6E   �� *
priceUsd+�� 5      $
 auto��6%   $��
Asset name��62    6F   �� *name+�� 5      $ 35��6%   $
��Rank��60    6>   �� *rank+5      5      �� 5   
   -   5         ��Name$ slider��5      $	 478��6!   $ 29��63   $	��291��6C   $
��Left=�6O   $��Center=�6j    � Minimum$ 1Q�6�   	 � Maximum$		 100Q�6�   
 �� TickPlacement$
 BottomRight=�6�    � Cursor$ Arrow��6�    �� AutoToolTipPlacement$ BottomRight=�6�   �� 5   
   -   5         ��Name$ assetsListTopN��5      $	 478��6+   $ 65��6=   $	��291��6M   $
��Left=�6Y   $��Center=�6t   $	��251��6�    5        5       5      �� 5      .P�5       �� $
 auto��6%   $��	Price USD��62    6E   �� *
priceUsd+�� 5!      $
 auto��6%   $��
Asset name��62    6F   �� *name+�� 5"      $ 35��6%   $
��Rank��60    6>   �� *rank+5#      5%      �� 5&   
   -   5         ��Name$ label��5&      $)��#Top 10 currencies returned by API: ��6   $ 10��5'      $ 10��6!   $��Center=�61   $	��Top=�6N   �� 5(   
   -   5         ��Name$ button��5(      $��Select��6!   $��24��62   $	 697��6>   $	 321��6P   $��72��6a   $
��Left=�6l   $��Center=�6�   6�   5*      5,      