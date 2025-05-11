🧠 Optimized Update System with Observer Pattern
🚨 Problem: Inefficient Update Checks \n
In large-scale Unity projects, performance bottlenecks often arise due to how Update() is handled in every component. By default, Unity checks multiple conditions each frame (as shown in the image below), including:
1)Null checks
2)Destruction checks
3)Activation status
4)Start flags

Parameter validation
![image](https://github.com/user-attachments/assets/36366bd1-4f63-4614-8c7f-149576b9f803)
These checks accumulate quickly as the number of components increases, leading to performance degradation in complex games.

✅ Solution: Update Publisher (Observer Pattern)
To solve this, I’ve implemented an Update Publisher system using the Observer Pattern.
Instead of having every component run its own Update(), only one central UpdatePublisher is active. It notifies all registered listeners (subscribers) that require per-frame updates.

🧩 How It Works
Components that require per-frame updates implement an interface, e.g., IUpdateObserver.
These components register/unregister themselves with the UpdatePublisher.
UpdatePublisher calls their OnUpdate() method during the game’s update cycle.
This avoids redundant system-level checks and significantly boosts performance for games with hundreds or thousands of active scripts.


🚀 Benefits
💡 Single point of control over per-frame updates
⚡ Improved performance, especially in large scenes
🔍 Easier debugging and profiling
🧩 Encourages cleaner and decoupled architecture
