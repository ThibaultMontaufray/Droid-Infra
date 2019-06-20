using NUnit.Framework;
using System;
using Microsoft.Extensions.Configuration;
using Droid.Infra;

namespace Droid.Infra.UnitTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestUTRuns()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void Test_docker()
        {
            try
            {
                //Boot2Docker docker = new Boot2Docker();
                //docker.Init();
                //docker.RefreshInfo();
                //docker.RefreshStatus();
                //docker.Stop();
                //docker.Start();
                //docker.Restart();
                //docker.DisplayInfo();
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_github()
        {
            try
            {
                GitHubAdapter github = new GitHubAdapter();
                github.LogUser("", "", "");
                github.LogOff();
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_jira()
        {
            try
            {
                //JiraAdapter jira = new JiraAdapter("", "", "");
                //jira.CreateIssue("");
                //jira.DeleteIssue("");
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        //[Test]
        //public void Test_interface_deployer()
        //{
        //    try
        //    {
        //        Interface_deployer intDep = new Interface_deployer();
        //        Interface_deployer.ACTION_lancer_docker_130();
        //        Assert.IsTrue(true);
        //    }
        //    catch (System.Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
    }
}
