using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Metadata
{
    public class T_E_COMPTE_CPTMetadata
    {
        

        [Phone]
        [Display(Name = "Telephone")]
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Erreur de saisie pour le numéro de téléphone")]
        public string CPT_TELPORTABLE { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage =
            " La longueur  du nom  doit  être  comprise  entre  6  et  100 caractères")]
        [Display(Name = "Last Name")]
        public string CPT_NOM { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage =
            " La longueur  du prenom  doit  être  comprise  entre  6  et  100 caractères")]
        [Display(Name = "First Name")]
        public string CPT_PRENOM { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [StringLength(100, MinimumLength = 6, ErrorMessage =
            " La longueur  d’un  email  doit  être  comprise  entre  6  et  100 caractères")]
        public string CPT_MEL { get; set; }

        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&])[A-Za-z0-9$@$!%*?&]{6,10}", ErrorMessage = "Erreur de saisie pour du mot de passe, doit contenir 1 majuscule, 1 chiffre et 1 caractère spécial entre 6 et 10 caractères")]
        [Display(Name = "password")]
        public string CPT_PWD { get; set; }

        [StringLength(200, MinimumLength = 1, ErrorMessage =
            " La longueur  de la rue  doit  être  comprise  entre  6  et  100 caractères")]
        [Display(Name = "Rue")]
        public string CPT_RUE { get; set; }

        [RegularExpression("[0-9]{5}$", ErrorMessage = "Erreur de saisie du code postal 5 chiffre")]
        [Display(Name = "Code postal")]
        public string CPT_CP { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage =
            " La longueur  de la ville  doit  être  comprise  entre  6  et  100 caractères")]
        [Display(Name = "Ville")]
        public string CPT_VILLE { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage =
            " La longueur  du pays  doit  être  comprise  entre  6  et  100 caractères")]
        [Display(Name = "Pays")]
        public string CPT_PAYS { get; set; }


        /*
        public string CPT_PWD { get; set; }
        public string CPT_RUE { get; set; }
        public string CPT_CP { get; set; }
        public string CPT_VILLE { get; set; }
        public string CPT_PAYS { get; set; }

        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Erreur de saisie pour le numéro de téléphone")]

    */
    }
}