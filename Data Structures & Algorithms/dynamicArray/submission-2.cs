public class DynamicArray {
    List<int> newList = new List<int>();
    private int _capacity;
    public DynamicArray(int capacity) {
        _capacity = capacity;
    }
    public int Get(int i) {
        return newList[i];
    }

    public void Set(int i, int n) {
        newList[i] = n;
    }

    public void PushBack(int n) {
        
        if(_capacity == newList.Count){
            Resize();
        }
        newList.Add(n);
    }

    public int PopBack() {
        var n = newList[^1];
        newList.RemoveAt(newList.Count-1);
        return n;
    }

    public void Resize() {
        _capacity *= 2;
    }

    public int GetSize() {
        return newList.Count;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
