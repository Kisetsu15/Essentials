# Essentials - Unity Utility Library

Essentials is a collection of **utility scripts** for Unity, designed to streamline development by providing helpful **extension methods** and common functionality for **GameObjects, Collections, and Timers**.

## 📌 Features

✅ **GameObject Utilities** - Hide, Show, and check for components easily.  
✅ **Precondition Checks** - Ensure objects are not null before use.  
✅ **Timers** - Simple time-based logic without coroutines.  
✅ **Collection Extensions** - Get a formatted string of a collection or pick a random element.

---

## 📥 Installation
1. Clone the repository or download the source files:
   ```sh
   git clone https://github.com/Kisetsu15/Essentials.git
   ```
2. Add the `Essentials` namespace to your scripts:
   ```csharp
   using Essentials;
   ```

---

## 🚀 Usage

### 🔹 GameObject Utilities ([GameObjectUtils.cs](GameObjectUtils.cs))
#### Hide & Show GameObjects
```csharp
GameObject obj = someGameObject;
obj.Hide(); // Hides the object
obj.Show(); // Shows the object
```
#### Check for Components
```csharp
if (obj.HasComponent<Rigidbody>()) {
    Debug.Log("Rigidbody is attached to this object.");
}
```

---

### 🔹 Precondition Checks ([Preconditions.cs](Preconditions.cs))
```csharp
Preconditions.CheckNotNull(obj, "Object cannot be null");
```

---

### 🔹 Timers ([Timer.cs](Timer.cs))
#### Simple Timer Usage
```csharp
Timer myTimer = new Timer();
if (myTimer.SetTimer(5f, false)) {
    Debug.Log("Timer completed!");
}
```

---

### 🔹 Collection Extensions ([CollectionExtensions.cs](CollectionExtensions.cs))
#### Convert Collection to String
```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Debug.Log(numbers.All()); // Output: [ 1, 2, 3, 4, 5 ]
```
#### Get a Random Element
```csharp
Debug.Log(numbers.Random()); // Output: Random number from the list
```

---

## 📜 Contributing
1. **Fork** the repository.
2. **Create** a new branch (`feature-xyz`).
3. **Commit** your changes (`git commit -m 'Add feature xyz'`).
4. **Push** to your branch (`git push origin feature-xyz`).
5. **Create a Pull Request** for review.

---

## ⚖️ License
This project is licensed under the **MIT License**. Feel free to use and modify it!

