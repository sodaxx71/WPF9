   M S B A M L   `   `   `  ����D  @Task9.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Task9.App.ViewTask9.App.View  5   	   %    Task9.App.View.CoffeeDetailView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Task9.App.View     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $	��400��5   	   $	��600��5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   ���#121212 � DataContext 5
   	   ��    mainViewModelLocator �� Source# [   �� Path$ CoffeeDetailViewModel�.��5      �� .��5   
   � $��5q�6   ���#1E1E1E � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��55 �6    �� 5      $	��200 �6    �� 5      $��30 �6    �� 5      $
��Auto �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5       $��30 �6    �� 5!      $��* �6    �� 5"      $��50 �6    �� 5#      $��30 �6    .+�5&      �� $��1��5)      $��2��5*      $	��150��5+      $	��150��5,       # MaterialDesignElevationShadow16 J� Effect# [ 5-      ��5&      �� *SelectedCoffee.ImageId+  localImageConverter	 �� 	Converter#	 [ 
 �� Mode$
 OneWay=�5-      �� 5/      $��2��6   $
��№:��6!   $
��Bold"�6.   
�������6@   �� 50      $��3��6   $��Описание:��6!   $
��Bold"�65   $��Center=�6G   
�������6b   �� 51      $��4��6   $��	Цена:��6!   $
��Bold"�61   
�������6C   �� 52      $��5��6   $��На складе:��6!   $
��Bold"�66   
�������6H   �� 53      $��6��6   $��Поступление:��6!   $
��Bold"�68   
�������6J   �� 55      $��2��6   $��1��6#    �� TextWrapping$
 Wrap=�59      
����������#424242
��������56      �� *SelectedCoffee.CoffeeId+  localDoNothingConverter#	 [ $
 TwoWay=�5<      �� 5>      $��3��6   $��1��6#    �� AcceptsReturn . $
 Wrap=�5B      $��75��5C      
����������#424242
��������5?      �� *SelectedCoffee.Description+$
 TwoWay=�5F      �� 5H      $��4��6   $��1��6#   
����������#424242
��������5I      �� *SelectedCoffee.Price+$
 TwoWay=�5M      �� 5O      $��5��6   $��1��6#   
����������#424242
��������5P      �� *SelectedCoffee.AmountInStock+$
 TwoWay=�5T      �� 5V      $��6��6   $��1��6#   
����������#424242
��������5W      �� *&$SelectedCoffee.FirstAddedToStockDate+$
 TwoWay=�5[      �� 5]      $��9��6    �� Orientation$ 
Horizontal=�6&   $��2��6?   $��Center=�6S   .+�5^      �� $��5q�6   $��Сохранить��6$     MaterialDesignFlatButton#��[ 5_      3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   Value$ -1Q�5`         IsIndicatorVisible .    IsIndeterminate . {�5c      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5f      +  %Microsoft.Xaml.Behaviors.EventTrigger  5g         	EventName$ Click��6)   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5h      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 64   �� *SaveCommand+5i      5k      �� 5m      $��5q�6   $��Удалить��6$   #��[ 5n      $ -1Q�5o       .  . {�5r      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL� 5u        5v      $ Click��6)   . 5w         64   �� *DeleteCommand+5x      5z      5{      5|      5}      5~      