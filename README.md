# Singleton

A singleton is a development pattern that prevents having multiple instances of the same component in a scene.
It allows also any script to access this one wihout requiring a manual link between the two.

This one is a generic Singleton that allows you to inherit from it from your class to access its instance with the static Instance property.
There are two singleton:
- Singleton<T> that inherits from MonoBehaviour
- SimpleSingleton that does not

## Usage

Extends the Singleton<T> class from your own classes like this :

```C#
public class MyBrandNewClass : Singleton<MyBrandNewClass> {
// ...
}
```

You can call it from other scripts like this :

```C#
MyBrandNewClass.Instance.PublicMethod()
```

See Transition class for a demo.