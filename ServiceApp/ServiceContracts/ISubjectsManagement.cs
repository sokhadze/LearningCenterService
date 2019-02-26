using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceApp
{
    [ServiceContract]
    public interface ISubjectsManagement
    {

        [OperationContract]
        [WebGet(UriTemplate= "/GetAllSubjects")]
        List<SubjectDTO> GetAllSubjects();

        [OperationContract]
        [WebGet(UriTemplate = "/GetSubjectByCode/{code}")]
        List<SubjectDTO> GetSubjectByCode(string code);
    }

}
