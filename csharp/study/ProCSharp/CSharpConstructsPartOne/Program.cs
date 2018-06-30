using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreCSharpPrograming.chap3.StringData;
using CoreCSharpPrograming.chap5.CSharpEncapsulation;
using CoreCSharpPrograming.chap7.unhandledexceptiondebugging;
using CoreCSharpPrograming.chap8.ienumerableandienumerator;
using CoreCSharpPrograming.chap8.icloneableinterface;
using CoreCSharpPrograming.chap8.icomparableinterface;
using CoreCSharpPrograming.chap9.motivationforcollectionclasses;
using CoreCSharpPrograming.chap9.nongenericcollectionissues;
using CoreCSharpPrograming.chap9.genericnamespace;
using CoreCSharpPrograming.chap10.simpledelegate;
using CoreCSharpPrograming.chap10.sendingobjectstatenotifications;
using CoreCSharpPrograming.chap11.operatoroverloading;
using CoreCSharpPrograming.chap11.customtypeconversion;
using CoreCSharpPrograming.chap11.extensionmethod;
using CoreCSharpPrograming.chap11.anonymoustypes;

namespace CoreCSharpPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chap3Exec();

            // Chap5Exec();

            // Chap7Exec();

            // Chap8Exec();

            // Chap9Exec();

            // Chap10Exec();

            Chap11Exec();
        }

        private static void Chap3Exec()
        {
            // String Manipulation
            new StringDataExec().Exec();
        }

        private static void Chap5Exec()
        {
            new CSharpEncapsulationServices().Exec();
        }

        private static void Chap7Exec()
        {
            new UnhandledExceptionDebuggingExec().Exec();
        }

        private static void Chap8Exec()
        {
            // new IEnumerableAndIEnumeratorInterfaceUsageExec().Exec();

            // new ICloneableInterfaceUsageExec().Exec();

            new IComparableInterfaceExec().Exec();
        }


        private static void Chap9Exec()
        {
            new MotivationForCollectionClassesExec().Exec();

            new NonGenericCollectionsIssuesExec().Exec();

            new GenericNamespaceExec().Exec();
        }

        private static void Chap10Exec()
        {
            // new SimpleDelegateExec().Exec();

            new SendingObjectStateNotificationsExec().Exec();
        }

        private static void Chap11Exec()
        {
            //  new OperatorOverloadingUsageExec().Exec();

            // new CustomTypeConversionExec().Exec();

            // new ExtensionMethodExec().Exec();

            new AnonymousTypesExec().Exec();
        }
    }
}
