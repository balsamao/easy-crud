using EasyCrud.Shared.DomainObjects.ObjectsValues;

namespace EasyCrud.Shared.DomainObjects
{
    public class Knowledge : ObjectValue
    {
        public Knowledge(Weight ionic, Weight reactJS, Weight reactNative, Weight android, Weight flutter, Weight sWIFT, Weight iOS, Weight hTML, Weight cSS, Weight bootstrap, Weight jquery, Weight angularJs, Weight angular, Weight java, Weight python, Weight flask, Weight aspNetMVC, Weight aspNetWebForm, Weight c, Weight csharp, Weight nodeJS, Weight expressNodeJs, Weight cake, Weight django, Weight majento, Weight pHP, Weight vue, Weight wordpress, Weight ruby, Weight mySQLServer, Weight mySQL, Weight salesforce, Weight photoshop, Weight illustrator, Weight sEO, Weight laravel)
        {
            Ionic = ionic;
            ReactJS = reactJS;
            ReactNative = reactNative;
            Android = android;
            Flutter = flutter;
            SWIFT = sWIFT;
            IOS = iOS;
            HTML = hTML;
            CSS = cSS;
            Bootstrap = bootstrap;
            Jquery = jquery;
            AngularJs = angularJs;
            Angular = angular;
            Java = java;
            Python = python;
            Flask = flask;
            AspNetMVC = aspNetMVC;
            AspNetWebForm = aspNetWebForm;
            C = c;
            Csharp = csharp;
            NodeJS = nodeJS;
            ExpressNodeJs = expressNodeJs;
            Cake = cake;
            Django = django;
            Majento = majento;
            PHP = pHP;
            Vue = vue;
            Wordpress = wordpress;
            Ruby = ruby;
            MySQLServer = mySQLServer;
            MySQL = mySQL;
            Salesforce = salesforce;
            Photoshop = photoshop;
            Illustrator = illustrator;
            SEO = sEO;
            Laravel = laravel;

            Validate();
        }

        public Weight Ionic { get; private set; }
        public Weight ReactJS { get; private set; }
        public Weight ReactNative { get; private set; }
        public Weight Android { get; private set; }
        public Weight Flutter { get; private set; }
        public Weight SWIFT { get; private set; }
        public Weight IOS { get; private set; }
        public Weight HTML { get; private set; }
        public Weight CSS { get; private set; }
        public Weight Bootstrap { get; private set; }
        public Weight Jquery { get; private set; }
        public Weight AngularJs { get; private set; }
        public Weight Angular { get; private set; }
        public Weight Java { get; private set; }
        public Weight Python { get; private set; }
        public Weight Flask { get; private set; }
        public Weight AspNetMVC { get; private set; }
        public Weight AspNetWebForm { get; private set; }
        public Weight C { get; private set; }
        public Weight Csharp { get; private set; }
        public Weight NodeJS { get; private set; }
        public Weight ExpressNodeJs { get; private set; }
        public Weight Cake { get; private set; }
        public Weight Django { get; private set; }
        public Weight Majento { get; private set; }
        public Weight PHP { get; private set; }
        public Weight Vue { get; private set; }
        public Weight Wordpress { get; private set; }
        public Weight Ruby { get; private set; }
        public Weight MySQLServer { get; private set; }
        public Weight MySQL { get; private set; }
        public Weight Salesforce { get; private set; }
        public Weight Photoshop { get; private set; }
        public Weight Illustrator { get; private set; }
        public Weight SEO { get; private set; }
        public Weight Laravel { get; private set; }

        public override void Validate() { }
    }
}
