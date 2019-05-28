
# react-native-library-grisaitis

## Getting started

`$ npm install react-native-library-grisaitis --save`

### Mostly automatic installation

`$ react-native link react-native-library-grisaitis`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-library-grisaitis` and add `RNLibraryGrisaitis.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNLibraryGrisaitis.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNLibraryGrisaitisPackage;` to the imports at the top of the file
  - Add `new RNLibraryGrisaitisPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-library-grisaitis'
  	project(':react-native-library-grisaitis').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-library-grisaitis/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-library-grisaitis')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNLibraryGrisaitis.sln` in `node_modules/react-native-library-grisaitis/windows/RNLibraryGrisaitis.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Library.Grisaitis.RNLibraryGrisaitis;` to the usings at the top of the file
  - Add `new RNLibraryGrisaitisPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNLibraryGrisaitis from 'react-native-library-grisaitis';

// TODO: What to do with the module?
RNLibraryGrisaitis;
```
  