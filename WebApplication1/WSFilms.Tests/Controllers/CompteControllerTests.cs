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
            controller.DeleteCompte(resultPost.CPT_ID);
            
        }

        [TestMethod()]
        public void PutCompteTest()
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

            T_E_COMPTE_CPT updateCompte = new T_E_COMPTE_CPT();
            updateCompte.CPT_CP = "66666";
            updateCompte.CPT_NOM = "test";
            updateCompte.CPT_PRENOM = "prenom";
            updateCompte.CPT_PWD = "Password1@";
            updateCompte.CPT_RUE = "test rue";
            updateCompte.CPT_TELPORTABLE = "0987595029";
            updateCompte.CPT_PAYS = "Wazambie";
            updateCompte.CPT_VILLE = "Paris";
            updateCompte.CPT_MEL = "testtest@test.com";

            var resultPut = (controller.PutCompte(resultPost.CPT_ID,updateCompte) as OkNegotiatedContentResult<T_E_COMPTE_CPT>).Content;


            Assert.AreEqual(updateCompte.CPT_CP, resultPut.CPT_CP);
            Assert.AreEqual(updateCompte.CPT_NOM, resultPut.CPT_NOM);
            Assert.AreEqual(updateCompte.CPT_PRENOM, resultPut.CPT_PRENOM);
            Assert.AreEqual(updateCompte.CPT_PWD, resultPut.CPT_PWD);
            Assert.AreEqual(updateCompte.CPT_RUE, resultPut.CPT_RUE);
            Assert.AreEqual(updateCompte.CPT_TELPORTABLE, resultPut.CPT_TELPORTABLE);
            Assert.AreEqual(updateCompte.CPT_PAYS, resultPut.CPT_PAYS);
            Assert.AreEqual(updateCompte.CPT_VILLE, resultPut.CPT_VILLE);


            controller.DeleteCompte(resultPut.CPT_ID);

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