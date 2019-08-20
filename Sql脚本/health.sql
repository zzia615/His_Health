if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.menu_info')
            and   type = 'U')
   drop table dbo.menu_info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.qx_info')
            and   type = 'U')
   drop table dbo.qx_info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.user_group_info')
            and   type = 'U')
   drop table dbo.user_group_info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.user_info')
            and   type = 'U')
   drop table dbo.user_info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.yy_info')
            and   type = 'U')
   drop table dbo.yy_info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.zd_info')
            and   type = 'U')
   drop table dbo.zd_info
go

drop schema dbo
go

/*==============================================================*/
/* User: dbo                                                    */
/*==============================================================*/
create schema dbo
go

/*==============================================================*/
/* Table: menu_info                                             */
/*==============================================================*/
create table dbo.menu_info (
   xtid                 int                  not null,
   code                 varchar(50)          not null,
   p_code               varchar(50)          null,
   name                 varchar(100)         null,
   classname            varchar(50)          null,
   fullclassname        varchar(100)         null,
   namespace            varchar(100)         null,
   assemblyname         varchar(100)         null,
   isexefile            int                  null,
   qybz                 int                  null,
   constraint PK_MENU_INFO primary key (xtid, code)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('dbo.menu_info') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'user', 'dbo', 'table', 'menu_info' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '菜单信息', 
   'user', 'dbo', 'table', 'menu_info'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'xtid')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'xtid'

end


execute sp_addextendedproperty 'MS_Description', 
   '系统ID',
   'user', 'dbo', 'table', 'menu_info', 'column', 'xtid'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'code'

end


execute sp_addextendedproperty 'MS_Description', 
   '菜单code',
   'user', 'dbo', 'table', 'menu_info', 'column', 'code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'p_code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'p_code'

end


execute sp_addextendedproperty 'MS_Description', 
   '父菜单',
   'user', 'dbo', 'table', 'menu_info', 'column', 'p_code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'name')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'name'

end


execute sp_addextendedproperty 'MS_Description', 
   '菜单名称',
   'user', 'dbo', 'table', 'menu_info', 'column', 'name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'classname')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'classname'

end


execute sp_addextendedproperty 'MS_Description', 
   '类名',
   'user', 'dbo', 'table', 'menu_info', 'column', 'classname'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'fullclassname')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'fullclassname'

end


execute sp_addextendedproperty 'MS_Description', 
   '完整类名',
   'user', 'dbo', 'table', 'menu_info', 'column', 'fullclassname'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'namespace')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'namespace'

end


execute sp_addextendedproperty 'MS_Description', 
   '命名空间',
   'user', 'dbo', 'table', 'menu_info', 'column', 'namespace'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'assemblyname')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'assemblyname'

end


execute sp_addextendedproperty 'MS_Description', 
   '程序集名称',
   'user', 'dbo', 'table', 'menu_info', 'column', 'assemblyname'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'isexefile')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'isexefile'

end


execute sp_addextendedproperty 'MS_Description', 
   '是否exe文件',
   'user', 'dbo', 'table', 'menu_info', 'column', 'isexefile'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.menu_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'qybz')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'menu_info', 'column', 'qybz'

end


execute sp_addextendedproperty 'MS_Description', 
   '启用标志',
   'user', 'dbo', 'table', 'menu_info', 'column', 'qybz'
go

/*==============================================================*/
/* Table: qx_info                                               */
/*==============================================================*/
create table dbo.qx_info (
   id                   int                  identity,
   xtid                 int                  null,
   user_code            varchar(50)          null,
   group_code           varchar(20)          null,
   menu_code            varchar(50)          null,
   constraint PK_QX_INFO primary key (id)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('dbo.qx_info') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'user', 'dbo', 'table', 'qx_info' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '权限信息', 
   'user', 'dbo', 'table', 'qx_info'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.qx_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'qx_info', 'column', 'id'

end


execute sp_addextendedproperty 'MS_Description', 
   '主键ID',
   'user', 'dbo', 'table', 'qx_info', 'column', 'id'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.qx_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'xtid')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'qx_info', 'column', 'xtid'

end


execute sp_addextendedproperty 'MS_Description', 
   '系统ID',
   'user', 'dbo', 'table', 'qx_info', 'column', 'xtid'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.qx_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'user_code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'qx_info', 'column', 'user_code'

end


execute sp_addextendedproperty 'MS_Description', 
   '用户编码',
   'user', 'dbo', 'table', 'qx_info', 'column', 'user_code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.qx_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'group_code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'qx_info', 'column', 'group_code'

end


execute sp_addextendedproperty 'MS_Description', 
   '组编码',
   'user', 'dbo', 'table', 'qx_info', 'column', 'group_code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.qx_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'menu_code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'qx_info', 'column', 'menu_code'

end


execute sp_addextendedproperty 'MS_Description', 
   '菜单编码',
   'user', 'dbo', 'table', 'qx_info', 'column', 'menu_code'
go

/*==============================================================*/
/* Table: user_group_info                                       */
/*==============================================================*/
create table dbo.user_group_info (
   code                 varchar(20)          not null,
   name                 varchar(50)          null,
   qybz                 int                  null,
   constraint PK_USER_GROUP_INFO primary key (code)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('dbo.user_group_info') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'user', 'dbo', 'table', 'user_group_info' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '用户组', 
   'user', 'dbo', 'table', 'user_group_info'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_group_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_group_info', 'column', 'code'

end


execute sp_addextendedproperty 'MS_Description', 
   '组编码',
   'user', 'dbo', 'table', 'user_group_info', 'column', 'code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_group_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'name')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_group_info', 'column', 'name'

end


execute sp_addextendedproperty 'MS_Description', 
   '组名称',
   'user', 'dbo', 'table', 'user_group_info', 'column', 'name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_group_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'qybz')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_group_info', 'column', 'qybz'

end


execute sp_addextendedproperty 'MS_Description', 
   '启用标志',
   'user', 'dbo', 'table', 'user_group_info', 'column', 'qybz'
go

/*==============================================================*/
/* Table: user_info                                             */
/*==============================================================*/
create table dbo.user_info (
   code                 varchar(50)          not null,
   name                 varchar(50)          null,
   password             varchar(50)          null,
   xtid                 int                  null,
   yqdm                 int                  null,
   qybz                 int                  null,
   "group"              varchar(500)         null,
   constraint PK_USER_INFO primary key (code)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('dbo.user_info') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'user', 'dbo', 'table', 'user_info' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '用户信息', 
   'user', 'dbo', 'table', 'user_info'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_info', 'column', 'code'

end


execute sp_addextendedproperty 'MS_Description', 
   '用户代码',
   'user', 'dbo', 'table', 'user_info', 'column', 'code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'name')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_info', 'column', 'name'

end


execute sp_addextendedproperty 'MS_Description', 
   '用户名称',
   'user', 'dbo', 'table', 'user_info', 'column', 'name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'password')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_info', 'column', 'password'

end


execute sp_addextendedproperty 'MS_Description', 
   '用户密码',
   'user', 'dbo', 'table', 'user_info', 'column', 'password'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'xtid')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_info', 'column', 'xtid'

end


execute sp_addextendedproperty 'MS_Description', 
   '系统ID',
   'user', 'dbo', 'table', 'user_info', 'column', 'xtid'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'yqdm')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_info', 'column', 'yqdm'

end


execute sp_addextendedproperty 'MS_Description', 
   '院区代码',
   'user', 'dbo', 'table', 'user_info', 'column', 'yqdm'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'qybz')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_info', 'column', 'qybz'

end


execute sp_addextendedproperty 'MS_Description', 
   '启用标志',
   'user', 'dbo', 'table', 'user_info', 'column', 'qybz'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.user_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'group')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'user_info', 'column', 'group'

end


execute sp_addextendedproperty 'MS_Description', 
   '所属分组',
   'user', 'dbo', 'table', 'user_info', 'column', 'group'
go

/*==============================================================*/
/* Table: yy_info                                               */
/*==============================================================*/
create table dbo.yy_info (
   code                 varchar(20)          not null,
   name                 varchar(50)          null,
   address              varchar(100)         null,
   tel                  varchar(50)          null,
   qybz                 int                  null,
   constraint PK_YY_INFO primary key (code)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('dbo.yy_info') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'user', 'dbo', 'table', 'yy_info' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '医院信息', 
   'user', 'dbo', 'table', 'yy_info'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.yy_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'yy_info', 'column', 'code'

end


execute sp_addextendedproperty 'MS_Description', 
   '院区编码',
   'user', 'dbo', 'table', 'yy_info', 'column', 'code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.yy_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'name')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'yy_info', 'column', 'name'

end


execute sp_addextendedproperty 'MS_Description', 
   '院区名称',
   'user', 'dbo', 'table', 'yy_info', 'column', 'name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.yy_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'address')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'yy_info', 'column', 'address'

end


execute sp_addextendedproperty 'MS_Description', 
   '院区地址',
   'user', 'dbo', 'table', 'yy_info', 'column', 'address'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.yy_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'tel')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'yy_info', 'column', 'tel'

end


execute sp_addextendedproperty 'MS_Description', 
   '联系电话',
   'user', 'dbo', 'table', 'yy_info', 'column', 'tel'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.yy_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'qybz')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'yy_info', 'column', 'qybz'

end


execute sp_addextendedproperty 'MS_Description', 
   '启用标志',
   'user', 'dbo', 'table', 'yy_info', 'column', 'qybz'
go

/*==============================================================*/
/* Table: zd_info                                               */
/*==============================================================*/
create table dbo.zd_info (
   dm                   int                  not null,
   p_dm                 int                  not null,
   code                 varchar(50)          null,
   mc                   varchar(100)         null,
   qybz                 int                  null,
   constraint PK_ZD_INFO primary key (dm, p_dm)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('dbo.zd_info') and minor_id = 0)
begin 
   execute sp_dropextendedproperty 'MS_Description',  
   'user', 'dbo', 'table', 'zd_info' 
 
end 


execute sp_addextendedproperty 'MS_Description',  
   '字典信息', 
   'user', 'dbo', 'table', 'zd_info'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.zd_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'dm')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'zd_info', 'column', 'dm'

end


execute sp_addextendedproperty 'MS_Description', 
   '代码',
   'user', 'dbo', 'table', 'zd_info', 'column', 'dm'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.zd_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'p_dm')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'zd_info', 'column', 'p_dm'

end


execute sp_addextendedproperty 'MS_Description', 
   '父亲代码',
   'user', 'dbo', 'table', 'zd_info', 'column', 'p_dm'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.zd_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'code')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'zd_info', 'column', 'code'

end


execute sp_addextendedproperty 'MS_Description', 
   '编码',
   'user', 'dbo', 'table', 'zd_info', 'column', 'code'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.zd_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'mc')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'zd_info', 'column', 'mc'

end


execute sp_addextendedproperty 'MS_Description', 
   '名称',
   'user', 'dbo', 'table', 'zd_info', 'column', 'mc'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('dbo.zd_info')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'qybz')
)
begin
   execute sp_dropextendedproperty 'MS_Description', 
   'user', 'dbo', 'table', 'zd_info', 'column', 'qybz'

end


execute sp_addextendedproperty 'MS_Description', 
   '启用标志',
   'user', 'dbo', 'table', 'zd_info', 'column', 'qybz'
go
