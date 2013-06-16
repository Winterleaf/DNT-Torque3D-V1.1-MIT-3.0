<?php /* Smarty version 2.6.18, created on 2013-06-06 06:04:55
         compiled from vc2k8_fileRecurseCSharp.tpl */ ?>
<?php require_once(SMARTY_CORE_DIR . 'core.load_plugins.php');
smarty_core_load_plugins(array('plugins' => array(array('modifier', 'replace', 'vc2k8_fileRecurseCSharp.tpl', 6, false),)), $this); ?>
<?php if (is_array ( $this->_tpl_vars['dirWalk'] )): ?>
<?php $_from = $this->_tpl_vars['dirWalk']; if (!is_array($_from) && !is_object($_from)) { settype($_from, 'array'); }if (count($_from)):
    foreach ($_from as $this->_tpl_vars['key'] => $this->_tpl_vars['dir']):
?>
<?php $_smarty_tpl_vars = $this->_tpl_vars;
$this->_smarty_include(array('smarty_include_tpl_file' => "vc2k8_fileRecurseCSharp.tpl", 'smarty_include_vars' => array('dirWalk' => $this->_tpl_vars['dir'],'dirName' => $this->_tpl_vars['key'],'dirPath' => ($this->_tpl_vars['dirPath']).($this->_tpl_vars['dirName'])."/",'depth' => $this->_tpl_vars['depth']+1)));
$this->_tpl_vars = $_smarty_tpl_vars;
unset($_smarty_tpl_vars);
 ?>
<?php endforeach; endif; unset($_from); ?>
<?php else: ?>
<Compile Include="<?php echo ((is_array($_tmp=$this->_tpl_vars['dirWalk']->path)) ? $this->_run_mod_handler('replace', true, $_tmp, '/', '\\') : smarty_modifier_replace($_tmp, '/', '\\')); ?>
" >
   <Link><?php echo ((is_array($_tmp=((is_array($_tmp=$this->_tpl_vars['dirWalk']->path)) ? $this->_run_mod_handler('replace', true, $_tmp, '../', '') : smarty_modifier_replace($_tmp, '../', '')))) ? $this->_run_mod_handler('replace', true, $_tmp, '/', '\\') : smarty_modifier_replace($_tmp, '/', '\\')); ?>
</Link>
</Compile>
<?php endif; ?>