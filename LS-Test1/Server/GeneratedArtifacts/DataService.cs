//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    public sealed partial class ApplicationDataService
        : global::LightSwitchApplication.ApplicationData
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ApplicationDataService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Inserting(global::LightSwitchApplication.Table1Item entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Inserted(global::LightSwitchApplication.Table1Item entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Updating(global::LightSwitchApplication.Table1Item entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Updated(global::LightSwitchApplication.Table1Item entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Deleting(global::LightSwitchApplication.Table1Item entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Deleted(global::LightSwitchApplication.Table1Item entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Validate(global::LightSwitchApplication.Table1Item entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Single_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Single_Executing(global::System.Nullable<int> Id);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Single_PreprocessQuery(global::System.Nullable<int> Id, ref global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Single_Executed(global::System.Nullable<int> Id, global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Table1Item> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_Single_ExecuteFailed(global::System.Nullable<int> Id, global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_SingleOrDefault_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_SingleOrDefault_Executing(global::System.Nullable<int> Id);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_SingleOrDefault_PreprocessQuery(global::System.Nullable<int> Id, ref global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_SingleOrDefault_Executed(global::System.Nullable<int> Id, global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Table1Item> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_SingleOrDefault_ExecuteFailed(global::System.Nullable<int> Id, global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_All_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_All_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_All_PreprocessQuery(ref global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_All_Executed(global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Table1Item> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Items_All_ExecuteFailed(global::System.Exception exception);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>
                __Table1ItemsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>(
                    "Table1Items",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Validate);
            private static bool __Table1Items_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Table1Items_CanInsert(ref result);
                return result;
            }
            private static bool __Table1Items_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Table1Items_CanUpdate(ref result);
                return result;
            }
            private static bool __Table1Items_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Table1Items_CanDelete(ref result);
                return result;
            }
            private static bool __Table1Items_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Table1Items_CanRead(ref result);
                return result;
            }
            private static void __Table1Items_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Table1Item e)
            {
                d.Table1Items_Inserting(e);
            }
            private static void __Table1Items_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Table1Item e)
            {
                d.Table1Items_Inserted(e);
            }
            private static void __Table1Items_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Table1Item e)
            {
                d.Table1Items_Updating(e);
            }
            private static void __Table1Items_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Table1Item e)
            {
                d.Table1Items_Updated(e);
            }
            private static void __Table1Items_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Table1Item e)
            {
                d.Table1Items_Deleting(e);
            }
            private static void __Table1Items_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Table1Item e)
            {
                d.Table1Items_Deleted(e);
            }
            private static void __Table1Items_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Table1Item e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Table1Items_Validate(e, r);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>(
                    "SaveChanges",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>
                __Table1Items_SingleEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>(
                    "Table1Items_Single",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Single_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Single_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Single_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Single_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_Single_PreprocessQuery);
            private static bool __Table1Items_Single_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.Table1Items_Single_CanExecute(ref r);
                return r;
            }
            private static void __Table1Items_Single_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Table1Items_Single_Executing((global::System.Nullable<int>)args[0]);
            }
            private static void __Table1Items_Single_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Table1Items_Single_Executed((global::System.Nullable<int>)args[0], (global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Table1Item>)args[1]);
            }
            private static void __Table1Items_Single_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.Table1Items_Single_ExecuteFailed((global::System.Nullable<int>)args[0], ex);
            }
            private static global::System.Linq.IQueryable __Table1Items_Single_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item>)args[1];
                d.Table1Items_Single_PreprocessQuery((global::System.Nullable<int>)args[0], ref query);
                return query;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>
                __Table1Items_SingleOrDefaultEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>(
                    "Table1Items_SingleOrDefault",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_SingleOrDefault_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_SingleOrDefault_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_SingleOrDefault_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_SingleOrDefault_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_SingleOrDefault_PreprocessQuery);
            private static bool __Table1Items_SingleOrDefault_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.Table1Items_SingleOrDefault_CanExecute(ref r);
                return r;
            }
            private static void __Table1Items_SingleOrDefault_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Table1Items_SingleOrDefault_Executing((global::System.Nullable<int>)args[0]);
            }
            private static void __Table1Items_SingleOrDefault_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Table1Items_SingleOrDefault_Executed((global::System.Nullable<int>)args[0], (global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Table1Item>)args[1]);
            }
            private static void __Table1Items_SingleOrDefault_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.Table1Items_SingleOrDefault_ExecuteFailed((global::System.Nullable<int>)args[0], ex);
            }
            private static global::System.Linq.IQueryable __Table1Items_SingleOrDefault_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item>)args[1];
                d.Table1Items_SingleOrDefault_PreprocessQuery((global::System.Nullable<int>)args[0], ref query);
                return query;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>
                __Table1Items_AllEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Table1Item>(
                    "Table1Items_All",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_All_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_All_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_All_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_All_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Table1Items_All_PreprocessQuery);
            private static bool __Table1Items_All_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.Table1Items_All_CanExecute(ref r);
                return r;
            }
            private static void __Table1Items_All_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Table1Items_All_Executing();
            }
            private static void __Table1Items_All_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Table1Items_All_Executed((global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Table1Item>)args[0]);
            }
            private static void __Table1Items_All_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.Table1Items_All_ExecuteFailed(ex);
            }
            private static global::System.Linq.IQueryable __Table1Items_All_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Table1Item>)args[0];
                d.Table1Items_All_PreprocessQuery(ref query);
                return query;
            }
    
        }
    
        #endregion
    }
    
    #endregion
}