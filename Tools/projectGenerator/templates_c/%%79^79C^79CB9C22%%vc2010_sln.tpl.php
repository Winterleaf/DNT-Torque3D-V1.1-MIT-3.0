<?php /* Smarty version 2.6.18, created on 2013-06-06 05:57:09
         compiled from vc2010_sln.tpl */ ?>
Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
<?php $_from = $this->_tpl_vars['projects']; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }$this->_foreach['projects'] = array('total' => count($_from), 'iteration' => 0);
if ($this->_foreach['projects']['total'] > 0):
    foreach ($_from as $this->_tpl_vars['project']):
        $this->_foreach['projects']['iteration']++;
?>
<?php if ($this->_tpl_vars['project']->name == 'DNT FPS Demo No Core'): ?>
Project("<?php echo '{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}'; ?>
") = "<?php echo $this->_tpl_vars['project']->name; ?>
", "<?php echo $this->_tpl_vars['project']->literalPath; ?>
", "<?php echo $this->_tpl_vars['project']->guid; ?>
"
EndProject
<?php endif; ?>
<?php if ($this->_tpl_vars['project']->name == 'DNT Empty Demo'): ?>
Project("<?php echo '{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}'; ?>
") = "<?php echo $this->_tpl_vars['project']->name; ?>
", "<?php echo $this->_tpl_vars['project']->literalPath; ?>
", "<?php echo $this->_tpl_vars['project']->guid; ?>
"
EndProject
<?php endif; ?>
<?php endforeach; endif; unset($_from); ?>

<?php $_from = $this->_tpl_vars['projects']; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }$this->_foreach['projects'] = array('total' => count($_from), 'iteration' => 0);
if ($this->_foreach['projects']['total'] > 0):
    foreach ($_from as $this->_tpl_vars['project']):
        $this->_foreach['projects']['iteration']++;
?>
<?php if ($this->_tpl_vars['project']->name == 'DNT FPS Demo No Core'): ?>
<?php else: ?>
<?php if ($this->_tpl_vars['project']->name == 'DNT Empty Demo'): ?>
<?php else: ?>
<?php if ($this->_tpl_vars['project']->projectFileExt == ".csproj"): ?>
<?php if ($this->_tpl_vars['project']->literalPath == ""): ?>
Project("<?php echo '{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}'; ?>
") = "<?php echo $this->_tpl_vars['project']->name; ?>
", "projects/<?php echo $this->_tpl_vars['project']->name; ?>
<?php echo $this->_tpl_vars['project_ext']; ?>
", "<?php echo $this->_tpl_vars['project']->guid; ?>
"
<?php else: ?>
Project("<?php echo '{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}'; ?>
") = "<?php echo $this->_tpl_vars['project']->name; ?>
", "<?php echo $this->_tpl_vars['project']->literalPath; ?>
", "<?php echo $this->_tpl_vars['project']->guid; ?>
"
<?php endif; ?>
<?php else: ?>
Project("<?php echo $this->_tpl_vars['solution_guid']; ?>
") = "<?php echo $this->_tpl_vars['project']->name; ?>
", "projects/<?php echo $this->_tpl_vars['project']->name; ?>
<?php echo $this->_tpl_vars['project_ext']; ?>
", "<?php echo $this->_tpl_vars['project']->guid; ?>
"
<?php endif; ?>
EndProject
<?php endif; ?>
<?php endif; ?>
<?php endforeach; endif; unset($_from); ?>
<?php $_from = $this->_tpl_vars['projectExtRefs']; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }if (count($_from)):
    foreach ($_from as $this->_tpl_vars['pname'] => $this->_tpl_vars['v']):
?>
Project("<?php echo $this->_tpl_vars['v'][2]; ?>
") = "<?php echo $this->_tpl_vars['pname']; ?>
", "<?php echo $this->_tpl_vars['v'][0]; ?>
", "<?php echo $this->_tpl_vars['v'][1]; ?>
"
EndProject
<?php endforeach; endif; unset($_from); ?>
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Mixed Platforms = Debug|Mixed Platforms
		Debug|Win32 = Debug|Win32
		Debug|x86 = Debug|x86
		Optimized Debug|Mixed Platforms = Optimized Debug|Mixed Platforms
		Optimized Debug|Win32 = Optimized Debug|Win32
		Optimized Debug|x86 = Optimized Debug|x86
		Release|Mixed Platforms = Release|Mixed Platforms
		Release|Win32 = Release|Win32
		Release|x86 = Release|x86
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
<?php $_from = $this->_tpl_vars['projects']; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }$this->_foreach['projects'] = array('total' => count($_from), 'iteration' => 0);
if ($this->_foreach['projects']['total'] > 0):
    foreach ($_from as $this->_tpl_vars['project']):
        $this->_foreach['projects']['iteration']++;
?>
<?php if ($this->_tpl_vars['project']->literalPath == ""): ?>
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Mixed Platforms.ActiveCfg = Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Mixed Platforms.Build.0 = Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Win32.ActiveCfg = Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Win32.Build.0 = Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|x86.ActiveCfg = Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Mixed Platforms.ActiveCfg = Optimized Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Win32.ActiveCfg = Optimized Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Win32.Build.0 = Optimized Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|x86.ActiveCfg = Optimized Debug|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Mixed Platforms.ActiveCfg = Release|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Win32.ActiveCfg = Release|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Win32.Build.0 = Release|Win32
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|x86.ActiveCfg = Release|Win32
<?php else: ?>
<?php if ($this->_tpl_vars['project']->literalPath == "..\..\DotNet Torque Empty DLL\DNT Empty DLL.csproj"): ?>
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Any CPU.Build.0 = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Mixed Platforms.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Mixed Platforms.Build.0 = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Win32.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|x86.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Any CPU.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Any CPU.Build.0 = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Mixed Platforms.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Mixed Platforms.Build.0 = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Win32.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|x86.ActiveCfg = Debug|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Any CPU.ActiveCfg = Release|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Any CPU.Build.0 = Release|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Mixed Platforms.ActiveCfg = Release|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Mixed Platforms.Build.0 = Release|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Win32.ActiveCfg = Release|Any CPU
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|x86.ActiveCfg = Release|Any CPU
<?php else: ?>
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Mixed Platforms.ActiveCfg = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Mixed Platforms.Build.0 = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|Win32.ActiveCfg = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|x86.ActiveCfg = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Debug|x86.Build.0 = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Mixed Platforms.ActiveCfg = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Mixed Platforms.Build.0 = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|Win32.ActiveCfg = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|x86.ActiveCfg = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Optimized Debug|x86.Build.0 = Debug|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Mixed Platforms.ActiveCfg = Release|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Mixed Platforms.Build.0 = Release|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|Win32.ActiveCfg = Release|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|x86.ActiveCfg = Release|x86
		<?php echo $this->_tpl_vars['project']->guid; ?>
.Release|x86.Build.0 = Release|x86	
<?php endif; ?>		
<?php endif; ?>		
<?php endforeach; endif; unset($_from); ?>
<?php $_from = $this->_tpl_vars['projectExtRefs']; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }if (count($_from)):
    foreach ($_from as $this->_tpl_vars['pname'] => $this->_tpl_vars['v']):
?>
		<?php echo $this->_tpl_vars['v'][1]; ?>
.Debug|Win32.ActiveCfg = Debug|Win32
		<?php echo $this->_tpl_vars['v'][1]; ?>
.Debug|Win32.Build.0 = Debug|Win32
		<?php echo $this->_tpl_vars['v'][1]; ?>
.Optimized Debug|Win32.ActiveCfg = Optimized Debug|Win32
		<?php echo $this->_tpl_vars['v'][1]; ?>
.Optimized Debug|Win32.Build.0 = Optimized Debug|Win32
		<?php echo $this->_tpl_vars['v'][1]; ?>
.Release|Win32.ActiveCfg = Release|Win32
		<?php echo $this->_tpl_vars['v'][1]; ?>
.Release|Win32.Build.0 = Release|Win32
<?php endforeach; endif; unset($_from); ?>
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal