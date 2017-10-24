using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models.Entity;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class CompteControllerTests
    {

        [TestInitialize()]


       /* [TestMethod()]
        public void PutCompteTest()
        {
           // PutCompteTest(); 


            Assert.Fail();

        }*/

        [TestMethod()]
        public void PostCompteTest()
        {
            CompteController controller = new CompteController();

            T_E_COMPTE_CPT newCompte = new T_E_COMPTE_CPT();
            newCompte.CPT_CP = "66666";
            newCompte.CPT_NOM = "test";
            newCompte.CPT_PRENOM = "prenom";
            newCompte.CPT_PWD = "Password1@";
            newCompte.CPT_RUE = "test rue";
            newCompte.CPT_TELPORTABLE = "0987595029";
            newCompte.CPT_PAYS = "Wazambie";
            newCompte.CPT_VILLE = "Paris";
            newCompte.CPT_MEL = "testtest@test.com";
            var resultPost = (controller.PostCompte(newCompte) as OkNegotiatedContentResult<T_E_COMPTE_CPT>).Content;
            Assert.AreEqual(resultPost.CPT_CP ,  newCompte.CPT_CP);
            
        }

        [TestMethod()]
        public void GetCompteTest()
        {
            // Réorganiser
            CompteController controller = new CompteController();

            // Agir
                //test get by id
            var resultById = (controller.GetCompte(1) as OkNegotiatedContentResult<T_E_COMPTE_CPT>).Content;
            Assert.IsNotNull(resultById);

                //test Get by mail
            var resultByMail = (controller.GetCompte(resultById.CPT_MEL) as OkNegotiatedContentResult<T_E_COMPTE_CPT>).Content;
            Assert.IsNotNull(resultByMail);
            Assert.IsTrue(resultById == resultByMail);

            //test get list
            IQueryable <T_E_COMPTE_CPT> listResult = controller.GetCompte() as IQueryable<T_E_COMPTE_CPT>;
            Assert.IsNotNull(listResult);    
            T_E_COMPTE_CPT result1 = listResult.Where(p => p.CPT_ID == resultById.CPT_ID).FirstOrDefault();
            Assert.IsNotNull(result1);
            Assert.IsTrue(resultById == result1);

            // Déclarer



            // Assert.IsTrue(result.All(n => string.Equals(n.CPT_NOM, nameTest);
        }
        
    }
}