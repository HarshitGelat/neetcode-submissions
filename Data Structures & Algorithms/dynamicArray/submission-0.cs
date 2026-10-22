public class DynamicArray {

    private int[] arr;
    private int size;
    
    public DynamicArray(int capacity) {
        arr = new int[capacity];
        size = 0;
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
        if (size == arr.Length) {
            Resize();
        }
        arr[size] = n;
        size++;
    }

    public int PopBack() {
        size--;
        return arr[size];
    }

    private void Resize() {
        int[] newArr = new int[arr.Length * 2];

        for (int i=0; i < arr.Length; i++) {
            newArr[i] = arr[i];
        }

        arr = newArr;
    }

    public int GetSize() {
       return size;
    }

    public int GetCapacity() {
        return arr.Length;
    }
}
