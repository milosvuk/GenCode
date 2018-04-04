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
 
public class linkprocessdocuments
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprocessdocuments()
{
 
  
 
}
 
public linkprocessdocuments (System.Int32 _idprojectprocessdocuments,System.String _processname,System.String _documentname,System.Int32 _id_process,System.Int32 _id_documents )
{
idprojectprocessdocuments=_idprojectprocessdocuments;
processname=_processname;
documentname=_documentname;
id_process=_id_process;
id_documents=_id_documents;
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
 
private System.String processname;
 
public System.String PROCESSNAME
{
get
{
return processname;
}
set
{
processname=value;
}
}
 
private System.String documentname;
 
public System.String DOCUMENTNAME
{
get
{
return documentname;
}
set
{
documentname=value;
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
 
 
public void New()
{
idprojectprocessdocuments = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
