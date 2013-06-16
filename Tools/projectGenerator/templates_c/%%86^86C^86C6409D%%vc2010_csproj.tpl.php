<?php /* Smarty version 2.6.18, created on 2013-06-06 06:04:55
         compiled from vc2010_csproj.tpl */ ?>
<?php echo '<?xml'; ?>
 version="1.0" encoding="utf-8"<?php echo '?>'; ?>

<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">Win32</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid><?php echo $this->_tpl_vars['GUID']; ?>
</ProjectGuid>
    <OutputType><?php if ($this->_tpl_vars['projSubSystem'] == 1): ?>Exe<?php elseif ($this->_tpl_vars['projSubSystem'] == 2): ?>WinExe<?php else: ?>Library<?php endif; ?></OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace><?php echo $this->_tpl_vars['projName']; ?>
</RootNamespace>
    <AssemblyName><?php echo $this->_tpl_vars['projName']; ?>
</AssemblyName>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|Win32' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>..\..\..\game\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <PlatformTarget>x86</PlatformTarget>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Optimized Debug|Win32' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>..\..\..\game\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <PlatformTarget>x86</PlatformTarget>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
    <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|Win32' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>..\..\..\game\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <PlatformTarget>x86</PlatformTarget>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Core">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include="System.Xml.Linq">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include="System.Data.DataSetExtensions">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <?php $_from = $this->_tpl_vars['projSettings']->references; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }if (count($_from)):
    foreach ($_from as $this->_tpl_vars['ref'] => $this->_tpl_vars['version']):
?>
        <?php if (( $this->_tpl_vars['version'] )): ?>
            <Reference Include="<?php echo $this->_tpl_vars['ref']; ?>
">
            <RequiredTargetFramework><?php echo $this->_tpl_vars['version']; ?>
</RequiredTargetFramework>
            </Reference>
        <?php else: ?>
            <Reference Include="<?php echo $this->_tpl_vars['ref']; ?>
" />
        <?php endif; ?>
    <?php endforeach; endif; unset($_from); ?>
  </ItemGroup>
  <ItemGroup>
<?php $this->assign('dirWalk', $this->_tpl_vars['fileArray']); ?>
<?php $_smarty_tpl_vars = $this->_tpl_vars;
$this->_smarty_include(array('smarty_include_tpl_file' => "vc2010_fileRecurseCSharp.tpl", 'smarty_include_vars' => array('dirWalk' => $this->_tpl_vars['dirWalk'],'depth' => 2,'dirPath' => $this->_tpl_vars['projOutput']->base_dir)));
$this->_tpl_vars = $_smarty_tpl_vars;
unset($_smarty_tpl_vars);
 ?>
  </ItemGroup>
  <ItemGroup>
  <?php $_from = $this->_tpl_vars['projDepend']; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }if (count($_from)):
    foreach ($_from as $this->_tpl_vars['dep']):
?>
    <ProjectReference Include="<?php echo $this->_tpl_vars['projectDepends'][$this->_tpl_vars['dep']]->name; ?>
.csproj">
      <Project><?php echo $this->_tpl_vars['projectDepends'][$this->_tpl_vars['dep']]->guid; ?>
</Project>
      <Name><?php echo $this->_tpl_vars['projectDepends'][$this->_tpl_vars['dep']]->name; ?>
</Name>
    </ProjectReference>
   <?php endforeach; endif; unset($_from); ?>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>