using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Text;
 
public class processdocuments
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public processdocuments()
{
 
  
 
}
 
public processdocuments (System.Int32 _idprojectprocessdocuments,System.Int32 _id_process,System.Int32 _id_documents,System.Int32 _id_company,System.Int32 _active )
{
idprojectprocessdocuments=_idprojectprocessdocuments;
id_process=_id_process;
id_documents=_id_documents;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idprojectprocessdocuments;
 
public System.Int32 IDPROJECTPROCESSDOCUMENTS
{
get
{
return idprojectprocessdocuments;
}
set
{
idprojectprocessdocuments=value;
}
}
 
private System.Int32 id_process;
 
public System.Int32 ID_PROCESS
{
get
{
return id_process;
}
set
{
id_process=value;
}
}
 
private System.Int32 id_documents;
 
public System.Int32 ID_DOCUMENTS
{
get
{
return id_documents;
}
set
{
id_documents=value;
}
}
 
private System.Int32 id_company;
 
public System.Int32 ID_COMPANY
{
get
{
return id_company;
}
set
{
id_company=value;
}
}
 
private System.Int32 active;
 
public System.Int32 ACTIVE
{
get
{
return active;
}
set
{
active=value;
}
}
 
 
public void New()
{
idprojectprocessdocuments = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
