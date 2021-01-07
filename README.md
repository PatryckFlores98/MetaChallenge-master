# MetaChallenge-master

Operation:

Para executar a feature, To run the feature, just compile, access the tests tab, open the test manager and run. (It is necessary to have updated Chrome, version 87).

Foram usados MSTest.TestAdapter(1.3.2),Newtonsoft.json(10.0.3),Selenium Support(3.1.41),Selenium.Chrome.WebDriver(87.0.0),Selenium(3.1.41), SpecFlow(2.4.1),SpecFlow.MsTest(2.4.1),SpecFlow.Tools.MsBuild.Generation(2.4.1),System.ValueTuple(4.4.0),NUnit(3.12),NUnit Adapter(3.15.1),MSTestFramework(1.3.2) e Gerkin(6.0.0) no gerenciador de pacotes NuGet.

The project has the Features folder, where there is a feature developed in the form of BDD, in addition to the Steps folder, where the feature steps are, and the pages folder, where they are as pages for each step. There is also an Util class, which contains the selenium methods and a SetUp class, for declaring global variables and executing the webdriver.
