using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Reflection;

namespace Aculocity.ProjectName.BLL
{
    /// <summary>
    /// Enable writing and reading to and from the App.config file
    /// </summary>
    public abstract class TimesheetAppDoConfig
    {
        public TimesheetAppDoConfig()
        {
            this.ReadAppConfig();
        }

        public void ReadAppConfig()
        {
             Type typeAppConfig = this.GetType();
           MemberInfo[] fields = typeAppConfig.GetMembers(BindingFlags.Public | BindingFlags.Instance );
       
          // *** If we have missing fields write at end
          bool missingFields = false;

          foreach (MemberInfo Member in fields)
          {
              string typeName = null;

              FieldInfo Field = null;
              PropertyInfo Property = null;

              if (Member.MemberType == MemberTypes.Field)
                  Field = (FieldInfo)Member;
              else if (Member.MemberType == (MemberTypes.Property))
                  Property = (PropertyInfo)Member;
              else
                  // Skip methods, events etc.
                  continue;

              if (Field != null)
                  typeName = Field.FieldType.Name.ToLower();
              else
                  typeName = Property.PropertyType.Name.ToLower();

              string Fieldname = Member.Name.ToLower();
              string Value = ConfigurationSettings.AppSettings[Fieldname];
              if (Value == null)
              {
                  missingFields = true;
                  continue;
              }

              /* if (typeName == "string")
                   wwUtils.SetPropertyEx(this,Fieldname,Value);
               else if (typeName.StartsWith("int") )
                           wwUtils.SetPropertyEx(this,Fieldname,Convert.ToInt32(Value));
               else if (typeName == "boolean") 
                  if (Value.ToLower() == "true") 
                            wwUtils.SetPropertyEx(this, Fieldname, true);
                  else
                    wwUtils.SetPropertyEx(this, Fieldname, false);
               else if (typeName == "datetime")           
                           wwUtils.SetPropertyEx(this, Fieldname, Convert.ToDateTime(Value));
               else if (typeName == "decimal") 
                  wwUtils.SetPropertyEx(this,Fieldname,
                                         Convert.ToDecimal(Value));
               //... More types omitted here
               else if(Field != null && Field.FieldType.IsEnum)
                  wwUtils.SetPropertyEx(this,Fieldname,Enum.Parse(Field.FieldType,Value) );
               else if (Property != null && Property.PropertyType.IsEnum)
                  wwUtils.SetPropertyEx(this,Fieldname, Enum.Parse(Property.PropertyType,Value)); }

                // *** We have to write any missing keys
                if (missingFields)
                   this.WriteKeysToConfig();*/
          }
        }
    }
}
