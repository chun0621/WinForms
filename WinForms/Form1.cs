namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string num = txtNum.Text;
            int n;

            if (!int.TryParse(num, out n) || n < 1)
            {
                MessageBox.Show("�п�J�����");
            }
            else
            {
                string result = "";
                //col
                for (int i = 0; i < n; i++)
                {
                    //row
                    for (int j = 0; j < 2 * n - 1; j++)
                    {
                        //����
                        if (j >= n - 1 - i && j <= n - 1 + i)
                        {
                            if ((j - (n - 1 - i)) % 2 == 0)
                            {
                                result += "*";
                            }
                            else
                            {
                                result += " ";
                            }
                        }
                        else
                        {
                            result += " ";
                        }
                    }
                    result += "\n";
                }
                lblAns.Text = result;
            }
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            string num = txtNum2.Text;
            int n;

            if (!int.TryParse(num, out n) || n < 1)
            {
                MessageBox.Show("�п�J1-100");
            }
            else
            {

                int[] people = new int[int.Parse(num)];

                // ��l�ƶ���
                for (int i = 0; i < n; i++)
                {
                    people[i] = i + 1;
                }

                int index = 0;
                int count = 0;

                while (n > 1)
                {
                    count++;
                    //��3�h�X
                    if (count % 3 == 0)
                    {
                        people[index] = 0;
                        n--;
                    }
                    //�H�����W
                    index = (index + 1) % people.Length;
                }


                int result = Array.Find(people, p => p != 0);
                lblAns2.Text = result.ToString();
            }
        }
    }
}