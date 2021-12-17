using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Carte
{
    public string name;
    public int PrixLunaire;
    public int PrixSolaire;
    public int PtVictoire;
    public CarteType type;
    public Effect effet;
    

    public Carte(string name,int prixL, int prixS,int ptVic,int NumeroTypeCarte)
    {
        name = name;
        PrixLunaire = prixL;
        PrixSolaire = prixS;
        PtVictoire = ptVic;
        type = new CarteType(NumeroTypeCarte);
    }

    public void CarteEffet(string Name, int NumeroTypeCarte)
    {
        switch (Name)
        {
            case "MARTEAU DU FORGERON":
                
                break;

            case "COFFRE DU FORGERON":
                //le joueur reçoit une extention de ressource");
                break;

            case "LA GRANDE OURSE":
                //effet = new Effect(3, "lorsque vous etes chassé recevez 3 Points de victoire");
                break;

            case "LES SABOTS D'ARGENT":
                //effet = new Effect(4, "recevez une faveur mineur");
                break;

            case "LE SANGLIER ACHARNE":
                //effet = new Effect(5, "appliquer la face sanglier acharné au dés d'un autre joueur recevez au choix l'une des ressources de la face lorsque le joueur tombe dessus");
                break;

            case "LES SATYRES":
                //effet = new Effect(6, "tous les joueurs lancent leurs Dés choississez 2 dés qui vous interressent et appliquer les ressources");
                break;

            case "L'ANCIEN":
                //effet = new Effect(7, "vous pouvez depenser 3 GOLDS pour gagner 4 Points de victoire");
                break;

            case "LES HERBES FOLLES":
                //effet = new Effect(8, "recevez 3 GOLDS et 3 Fragments Lunaires");
                break;

            case "LES AILES DE LA GARDIENNE":
                //effet = new Effect(9, "recevez 1 Gold ou 1 Fragment Lunaire ou 1 Fragment Solaire ");
                break;

            case "LA VOILE CELESTE":
                //effet = new Effect(10, "forgez sur votre Dé la face Voile celeste");
                break;

            case "LE MINOTAURE":
                //effet = new Effect(11, "tous les joueurs lancent leurs Dés et retire a leurs ressources ce que les faces indiques");
                break;

            case "LE BOUCLIER DE LA GARDIENNE":
                //effet = new Effect(12, "forger une face Bouclier de la gardienne");
                break;

            case "CERBERE":
                //effet = new Effect(13, "recever un jeton a usage unique cerbere apres avoir reçu une faveur vous pouvez la multiplier par 2");
                break;

            case "LE PASSEUR":
                //effet = new Effect(14, "pas d'effet");
                break;

            case "LE CASQUE D'INVISIBILITE":
                //effet = new Effect(15, "recevez une face *3 et forger la");
                break;

            case "LA SENTINELLE":
                //effet = new Effect(16, "recevez une faveur des dieux 2 * de suite pour chaque fragement lunaire ou solaire possibilité  de recevoir a la place 2 points de victoire");
                break;

            case "LA PINCE":
                //effet = new Effect(17, "recevez une faveur des dieux 2 * de suite");
                break;

            case "LA MEDUSE":
                //effet = new Effect(18, "pas d'effet");
                break;

            case "LE TRITON":
                //effet = new Effect(19, "recevez un jetton a usage unique triton le joueur peut ajouter a ces ressource au choix 2 fragment Solaire / 2 fragment lunaire ou 6 gold");
                break;

            case "LE MIROIR ABYSSAL":
                //effet = new Effect(20, "recevez une face mirroir abyssal");
                break;

            case "L'ENIGME":
                //effet = new Effect(21, "recevez une faveur mineur 4 * de suite");
                break;

            case "lE CYCLOPE":
                //effet = new Effect(22, "recevez une faveur mineur 4 * de suite pour chaque gain en gold il est possible de l'echanger contre 1 point de victoire");
                break;

            case "L'HYDRE":
                //effet = new Effect(23, "sans effet");
                break;

            case "LE TYPHON":
                //effet = new Effect(24, "recevez 1 point de victoire pour chaque face forgées");
                break;
        }

    }


}
