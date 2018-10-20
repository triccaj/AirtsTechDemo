# AirtsTechDemo

This solution uses the Selenium (C# bindings) libraries. The project targets .NET Framework 4.6.1.

### How to run these tests

This solution builds to a DLL file, which can be included as an artifact in most CI/CD release pipelines. All tests are discoverable by MSTest Runner, and most other test executors.

Open it in Visual Studio 2017. Rebuild. Open the Test Explorer, and Run the test.

It's really quick - I'd recommend a breakpoint on the first step and then a cheeky step through.

### Objective set out
* Navigate to Google and search for Airts
* Navigate through to the Values page
* Ensure Sense of Humour is intact

### Progress at completion
The exact spec has been met. This document aims to answer some of the broader questions in the challenge. Sense of humour was indeed, intact.

### How I would continue with this task
The next step is to map all the elements. Build a 'helpers' class, with common paths and actions throughout the site described; so for example NavigateToValues. This aids with re usability and gives one place to update should things change.

### Comments on the questions in the spec
From a performance perspective, this test runs on my machine in 6 seconds. It takes me approximately double that manually. The key benefit of doing this checking programatically is it's really boring to check this stuff manually.

In terms of changing Dev behaviour/thinking, it serves the purpose of effectively introducing double entry 'accounting' into the SDLC. The Dev has to both implement the story (which can take the mind away from simple questions like "Does this actually render on the browser?") AND must validate that all of them are actually invokable, on a browser, as a human. Generally in the industry, that last bit can essentially be seen as throwing the changes 'over the wall' to test, to see if they can find anything wrong.

I see it as moving into a far more collaborative space as now a tester can look at the broader process, focus on story quality and perform more novel exploratory testing.

N.B. I would personally recommend keeping the automation stuff in .NET Framework as my experiences with .NET Core (2.1 at least) show every browser action takes > 1 second and it's terrible...