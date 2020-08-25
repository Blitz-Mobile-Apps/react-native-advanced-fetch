
# react-native-advanced-fetch

## Getting started

`$ npm install react-native-advanced-fetch --save`

### Mostly automatic installation

`$ react-native link react-native-advanced-fetch`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-advanced-fetch` and add `RNAdvancedFetch.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAdvancedFetch.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAdvancedFetchPackage;` to the imports at the top of the file
  - Add `new RNAdvancedFetchPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-advanced-fetch'
  	project(':react-native-advanced-fetch').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-advanced-fetch/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-advanced-fetch')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAdvancedFetch.sln` in `node_modules/react-native-advanced-fetch/windows/RNAdvancedFetch.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Advanced.Fetch.RNAdvancedFetch;` to the usings at the top of the file
  - Add `new RNAdvancedFetchPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAdvancedFetch from 'react-native-advanced-fetch';

// TODO: What to do with the module?
RNAdvancedFetch;
```
  