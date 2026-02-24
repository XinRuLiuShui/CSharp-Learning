


> Written with [StackEdit](https://stackedit.io/).

 1. 把子项目中的`.cs`,`.Designer.cs`,`.resx`文件复制到目标项目文件夹下
 2. 在目标项目文件夹中新建`Resources`文件夹,把子项目`Resources`文件夹中的资料全复制过去
 3. 在目标项目中添加现有项,加入`.cs`,`.Designer.cs`,`.resx`文件
 4. 修改子项目中`.cs`文件中的命名空间,改为目标项目的命名空间
 5. 打开`.Designer.cs`,将子项目名改为目标项目名.
示例如下

	1.  **修改  FormLogin.cs  的命名空间**：
    
    -   打开  FormLogin.cs  文件。
    -   在文件顶部，找到  namespace _02_Login_UI。
    -   把它修改为  `namespace _05_Unified_App`。
	2.  **修改  FormLogin.Designer.cs  的代码**：
    
    -   在解决方案资源管理器中，展开  FormLogin.cs，找到并双击打开  FormLogin.Designer.cs  文件。
    -   使用  **查找和替换**  功能（快捷键  `Ctrl + H`）：
        -   **查找内容**：`global::_02_Login_UI.Properties.Resources`
        -   **替换为**：`global::_05_Unified_App.Properties.Resources`
    -   点击“全部替换”按钮。

6. 添加资源文件
	1.  **右键项目** → 选择 **"属性"**（或按 `Alt + Enter`）
    
	2.  切换到 **"资源"** 选项卡
    
	3.  点击 **"添加资源"** 下拉菜单 → 选择 **"添加现有文件..."**
    
	4.  浏览并选择你的图片文件（支持 .png, .jpg, .bmp, .ico 等格式）
    
	5.  图片会自动复制到 `Resources` 文件夹并嵌入到项目中





