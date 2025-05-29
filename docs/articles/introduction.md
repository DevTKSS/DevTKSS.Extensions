# Introduction

Welcome to this Extensions Documentation!

My name is Sonja Schweitzer, alias DevTKSS at GitHub and Discord.

I am an educated Technical Product Designer for Machines and Plant Engineering, but because of my Job is mostly digital it came in handy over time, to learn programming languages like C#, to automate my daily processes and to create Macros or Applications for my work.

## Contents of the Extensions

This Extensions are those I found useful to have available building applications in C#.

- **DevTKSS.Extensions:** A collection of general extensions for C#.
  - **MarshalExtensions:** enabling to use `MarshalExtensions.GetActiveObject(...)` to get the active object of a COM object relying on C++ dll import, so this requires still, to have them available in the system ( --> Windows only )

- **DevTKSS.Extensions.Uno**

  A collection of extensions enhancing the already great extensions of [unoplatform/Uno.Extensions](https://github.com/unoplatform/uno.extensions) and also relying on them, so using this package will add a dependency to the Uno.Extensions package and the Uno.Core and the Uno.Core.Extensions.Collections package, since it's using their EnumerableExtensions.

  - **`Storage.ReadLinesFromPackageFileAsync`**: Read selectively lines from a file in the package, like a txt file which does not have a serializable structure, but you only need parts of it, maybe also multiple parts not in one Range.
  - **`Enumerable.SelectItemsByRanges`**:
    - Enabling you to extend the capabilities of a `IEnumerable<string>` by providing a `IEnumerable<(int,int)>` to get only these Elements in this Ranges.
    - Additionally, its using `Math.Clamp` internally, which allows a secure and performant way, to make sure the values provided, are not less 0 and not exceeding the count in the IEnumerable you provided.

    > [!NOTE]
    > Make sure, you set the `nullBased` parameter to `false` if you want it to reduce each Range value by 1, which will make it fit the validation to this accordingly.
