  K      &   &Форма «$name$»   K     &   &Отчёт «$name$»   K     :   :документ $current$ из $overall$   K     8   8Документ базы данных    K     <   <копия сохранена в $location$   K     X   Xбиблиотека $type$ «$old$» перенесена в «$new$»   K     $   $%PRODUCTNAME Basic �  K        JavaScript t  K        BeanShell   K	        Java    K
        Python    K        диалог p  K     <   <переносим библиотеки ...   K        Ошибки p  K     .   .Предупреждения    K     >   >перехвачено исключение:    K     :   :$type$ библиотека «$library$»   K     j   jНеправильное количество аргументов. Ожидается 1.   K     b   bСреди аргументов нет документа базы данных. a  K     v   vНеприменимо к документу, доступному только для чтения. 1  K   <  D   �  @�   �  dbaccess:ModalDialog:DLG_MACRO_MIGRATION  Перенос макросов документов базы данных �        &   &Подготовка          N   NРезервное копирование документа o             Перенос B           Сводка o  K   3   �   �           pМестонахождение резервной копии должно отличаться от места расположения документа.  �  K   t  z   P  @?    �   dbaccess:TabPage:TP_PREPARE       (   �        �     W   �   �   �                          Добро пожаловать в мастер переноса макросов базы данных      W  �  �   �                         �Этот мастер предназначен для переноса макросов и сценариев.

После завершения этого процесса все макросы и сценарии, которые ранее были внедрены в формы и отчёты, будут перемещены в документ базы данных. В результате библиотеки будут надлежащим образом переименованы.

Если формы и отчёты содержат ссылки на эти макросы и сценарии, они будут скорректированы, если это возможно.

Перед началом переноса следует закрыть все формы, отчёты, запросы и таблицы. Для этого нажмите кнопку «Далее». �     W   �   �   �    �            �         
Не все объекты удалось закрыть автоматически. Закройте их вручную и перезапустите мастер.   K  t  �   V  @?    �   dbaccess:TabPage:TP_SAVE_DBDOC_AS       (   �        �     W   v   v   �                          Создание резервной копии документа      W  ,  ,   �                         (Для получения возможности возврата к состоянию перед переносом в указанном пользователем месте будет создана резервная копия документа базы данных. Каждое изменение, выполненное мастером, будет внесено в исходный документ, тогда как резервная копия останется неизменной.       W   L   L   �                H      <   Сохранить в: \     T   r   r  @?      dbaccess:ComboBox:TP_SAVE_DBDOC_AS:ED_SAVE_AS_LOCATION �      K   H      �              F   �   �  @�        dbaccess:PushButton:TP_SAVE_DBDOC_AS:PB_BROWSE_SAVE_AS_LOCATION       �   W      2   Обзор...      W   �   �   �                �         Для сохранения копии документа и начала переноса нажмите кнопку «Дальше».    K  t  �   P  @?    �   dbaccess:TabPage:TP_MIGRATE       (   �        �     W   L   L   �                          Ход переноса      W   �   �   �                         Документ базы данных содержит обрабатываемые в настоящее время форму(ы) $forms$ и отчёт(ы) $reports$:      W   R   R   �                 0      <   Текущий объект: �     W   4   4   ?              H   0      �        W   `   `   �                 >      <   Текущий ход выполнения:    	  W   4   4   ?              H   >      �        5   8   8   ?             H   I      �         
  W   \   \   �                [      <   Общий ход выполнения:      W   ^   ^   �              H   [      �   документ $current$ из $overall$      5   8   8   ?             H   f      �           W   �   �   �    �            �         Все документы были успешно обработаны. Для отображения подробной сводки нажмите кнопку «Далее».   K  t  \   P  @?    �   dbaccess:TabPage:TP_SUMMARY       (   �        �     W   B   B   �                          Сводка �     W   4   4   ?                              S   h   h  `?    B  dbaccess:MultiLineEdit:TP_SUMMARY:ED_CHANGES          %         �             �   �Перенос успешно завершен. Ниже отображается журнал действий, применённых к документу.          ~   ~Перенос не удался. Подробности смотрите в журнале переноса.    �    p             Resource �          String    y        StringArray           Bitmap            Color   #        Image   $        ImageList   5        Window    6        SystemWindow    7        WorkWindow S  <        ModalDialog   ;          ModelessDialog �  D        Control   E        Button    P        CheckBox    F        PushButton �  I        HelpButton �  G        OKButton    H        CancelButton �  N        RadioButton   O     "   "ImageRadioButton �  Q        TriStateBox   J        ImageButton   R        Edit �  S        MultiLineEdit   ]        ScrollBar   U        ListBox   V        MultiListBox    T        ComboBox �  W        FixedText   Y        FixedBitmap   Z        FixedImage �  \        GroupBox l          KeyCode             AcceleratorItem           Accelerator           MenuItem            Menu �  K        MenuButton    0        MessBox   1        InfoBox   2        WarningBox �  3        ErrorBox �  4        QueryBox �  _        Splitter    `        SplitWindow   M        SpinButton             Time �  !        Date �  a        SpinField   b        PatternField �  c        NumericField �  d        MetricField   e        CurrencyField   n     "   "LongCurrencyField   f        DateField   g        TimeField   h        PatternBox �  i        NumericBox    j        MetricBox   k        CurrencyBox   o          LongCurrencyBox   l        DateBox   m        TimeBox   r        DockingWindow   p        ToolBoxItem   q        ToolBox   s        StatusBar   L        MoreButton    9          FloatingWindow    t        TabPage   v        TabDialog   w        PageItem    u        TabControl    X        FixedLine   ^        ScrollBarBox �       $   $SfxStyleFamilyItem �       "   "SfxStyleFamilies �          SfxSlotInfo         �  �    K         K   &    K   L    K   �    K   �    K   �    K  R    K  v    K  �    K	  �    K
  �    K  �    K  �    K  4    K  R    K  �    K  �    K  �    K  b    K  �  3  K   ~  <  K   :  t  K   :  t  K  �  t  K  �  t  K  N  H