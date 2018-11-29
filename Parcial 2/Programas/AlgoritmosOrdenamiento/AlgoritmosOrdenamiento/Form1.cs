using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosOrdenamiento {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public void QuickSort() {
            txtMetodo.Text = "Quick Sort";
            String test = Numeros.Text;
            String[] words = test.Split(',');
            int size = words.Length;
            int[] vector = new int[size];
            for (int i = 0; i < size; i++) {
                vector[i] = Convert.ToInt32(words[i]);
            }
            quicksort(0, size - 1);
            mostrar();

            void quicksort(int primero, int ultimo) {
                int i, j, central;
                double pivote;
                central = (primero + ultimo) / 2;
                pivote = vector[central];
                i = primero;
                j = ultimo;
                do {
                    while (vector[i] < pivote) i++;
                    while (vector[j] > pivote) j--;
                    if (i <= j) {
                        int temp;
                        temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

                if (primero < j) {
                    quicksort(primero, j);
                }
                if (i < ultimo) {
                    quicksort(i, ultimo);
                }
            }

            void mostrar() {
                String test2 = "";
                for (int i = 0; i < size; i++) {
                    if (i == size - 1) {
                        test2 += Convert.ToString(vector[i]);
                    } else {
                        test2 += Convert.ToString(vector[i]) + ",";
                    }
                }
                txtOrdenados.Text = test2;
            }
        }

        public void BubbleSort() {
            txtMetodo.Text = "Bubble Sort";
            String test = Numeros.Text;
            String[] words = test.Split(',');
            int size = words.Length;
            int[] vector = new int[size];
            for (int i = 0; i < size; i++) {
                vector[i] = Convert.ToInt32(words[i]);
            }

            MetodoBurbuja();
            mostrar();

            void MetodoBurbuja() {
                int t;
                for (int a = 1; a < vector.Length; a++)
                    for (int b = vector.Length - 1; b >= a; b--) {
                        if (vector[b - 1] > vector[b]) {
                            t = vector[b - 1];
                            vector[b - 1] = vector[b];
                            vector[b] = t;
                        }
                    }
            }

            void mostrar() {
                String test2 = "";
                for (int i = 0; i < size; i++) {
                    if (i == size - 1) {
                        test2 += Convert.ToString(vector[i]);
                    } else {
                        test2 += Convert.ToString(vector[i]) + ",";
                    }
                }
                txtOrdenados.Text = test2;
            }
        }

        public void MergeSort() {
            txtMetodo.Text = "Merge Sort";
            String test = Numeros.Text;
            String[] words = test.Split(',');
            int size = words.Length;
            int[] vector = new int[size];
            for (int i = 0; i < size; i++) {
                vector[i] = Convert.ToInt32(words[i]);
            }

            MergeSort(vector, 0, vector.Length - 1);
            mostrar();


            void MergeSort(int[] input, int low, int high) {
                if (low < high) {
                    int middle = (low / 2) + (high / 2);
                    MergeSort(input, low, middle);
                    MergeSort(input, middle + 1, high);
                    Merge(input, low, middle, high);
                }
            }

            void Merge(int[] input, int low, int middle, int high) {

                int left = low;
                int right = middle + 1;
                int[] tmp = new int[(high - low) + 1];
                int tmpIndex = 0;

                while ((left <= middle) && (right <= high)) {
                    if (input[left] < input[right]) {
                        tmp[tmpIndex] = input[left];
                        left = left + 1;
                    } else {
                        tmp[tmpIndex] = input[right];
                        right = right + 1;
                    }
                    tmpIndex = tmpIndex + 1;
                }

                if (left <= middle) {
                    while (left <= middle) {
                        tmp[tmpIndex] = input[left];
                        left = left + 1;
                        tmpIndex = tmpIndex + 1;
                    }
                }

                if (right <= high) {
                    while (right <= high) {
                        tmp[tmpIndex] = input[right];
                        right = right + 1;
                        tmpIndex = tmpIndex + 1;
                    }
                }

                for (int i = 0; i < tmp.Length; i++) {
                    input[low + i] = tmp[i];
                }
            }

            void mostrar() {
                String test2 = "";
                for (int i = 0; i < size; i++) {
                    if (i == size - 1) {
                        test2 += Convert.ToString(vector[i]);
                    } else {
                        test2 += Convert.ToString(vector[i]) + ",";
                    }
                }
                txtOrdenados.Text = test2;
            }
        }

        public void HeapSort() {
            txtMetodo.Text = "Heap Sort";
            String test = Numeros.Text;
            String[] words = test.Split(',');
            int size = words.Length;
            int[] vector = new int[size];
            for (int i = 0; i < size; i++) {
                vector[i] = Convert.ToInt32(words[i]);
            }

            HeapSort(vector);
            mostrar();

            void HeapSort(int[] input) {
                //Build-Max-Heap
                int heapSize = input.Length;
                for (int p = (heapSize - 1) / 2; p >= 0; p--)
                    MaxHeapify(input, heapSize, p);

                for (int i = input.Length - 1; i > 0; i--) {
                    //Swap
                    int temp = input[i];
                    input[i] = input[0];
                    input[0] = temp;

                    heapSize--;
                    MaxHeapify(input, heapSize, 0);
                }
            }        

            void MaxHeapify(int[] input, int heapSize, int index) {
                int left = (index + 1) * 2 - 1;
                int right = (index + 1) * 2;
                int largest = 0;

                if (left < heapSize && input[left] > input[index])
                    largest = left;
                else
                    largest = index;

                if (right < heapSize && input[right] > input[largest])
                    largest = right;

                if (largest != index) {
                    int temp = input[index];
                    input[index] = input[largest];
                    input[largest] = temp;

                    MaxHeapify(input, heapSize, largest);
                }
            }

            void mostrar() {
                String test2 = "";
                for (int i = 0; i < size; i++) {
                    if (i == size - 1) {
                        test2 += Convert.ToString(vector[i]);
                    } else {
                        test2 += Convert.ToString(vector[i]) + ",";
                    }
                }
                txtOrdenados.Text = test2;
            }
        }

        private void Merge_Click(object sender, EventArgs e) {
            MergeSort();
        }

        private void Quick_Click(object sender, EventArgs e) {
            QuickSort();
        }

        private void Bubble_Click(object sender, EventArgs e) {
            BubbleSort();
        }

        private void hearp_Click(object sender, EventArgs e) {
            HeapSort();
        }
    }
}
