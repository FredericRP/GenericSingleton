[![openupm](https://img.shields.io/npm/v/com.fredericrp.singleton?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.fredericrp.singleton/)

# Generic Singleton

Generic version of singleton  for both MonoBehaviour and Standard classes.

Singleton is a development pattern that prevents having multiple instances of the same component in a scene.
It allows also any script to access this one wihout requiring a manual link between the two.

This one is a generic Singleton that allows you to inherit from it from your class to access its instance with the static Instance property.
There are two singleton:
- Singleton<T> that inherits from MonoBehaviour
- SimpleSingleton<T> that does not

## Usage

Extends the ```Singleton<T>``` (for MonoBehaviour singletons) or ```SimpleSingleton<T>``` (for standard classes singletons) class from your own classes like this:

```C#
public class MyBrandNewClass : Singleton<MyBrandNewClass> {
// ... fields, methods, etc.
}
```

You can call it from other scripts like this :

```C#
MyBrandNewClass.Instance.PublicMethod()
```

See Transition class for a demo.