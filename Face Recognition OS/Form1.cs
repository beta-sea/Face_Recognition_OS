using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_Recognition_OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_faceDetect_ClickAsync(object sender, EventArgs e)
        {

            var imageStr = ImageToUtil.ImgToBase64String(this.pictureBox1.Image);
            string json = FaceDetect.detectBASE64(imageStr);
            FaceDetectResultJsonModel jsonModel = JsonConvert.DeserializeObject<FaceDetectResultJsonModel>(json);
            string content = "年龄:{0}\n性别:{1}\n颜值:{2}";
            content = string.Format(content, jsonModel.result.face_list[0].age,
                jsonModel.result.face_list[0].gender.type, jsonModel.result.face_list[0].beauty);
            this.label_faceDetect.Text = content;

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

            var path = ((Array)(e.Data.GetData(DataFormats.FileDrop))).GetValue(0).ToString();

            this.pictureBox1.Image = Image.FromFile(path);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void but_FaceRegistered_Click(object sender, EventArgs e)
        {
            var imageStr = ImageToUtil.ImgToBase64String(this.pictureBox1.Image);
            string name = this.text_name.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入姓名");
                return;
            }
            Guid uid = Guid.NewGuid();

            this.label_state.Text = "正在上传数据";
            string json = FaceAdd.registeredBASE64(imageStr, "Test", name);
            FaceAddResultJsonModel jsonModel = JsonConvert.DeserializeObject<FaceAddResultJsonModel>(json);
            
            if(jsonModel.error_code != 0)
            {
                MessageBox.Show("上传失败");
                this.label_state.Text = "";
                return;
            }
            else
            {
                this.label_state.Text = "上传成功";
            }

            this.label_state.Text = "正在添加数据";
            Student stu = new Student()
            {
                ID = uid,
                Name = name,
                @Class = "Test",
                @Image = ImageToUtil.ImageToByteArr(this.pictureBox1.Image),
                face_token = jsonModel.result.face_token,
            };
            int result = StudentDBHelper.AddStudentEntity(stu);
            if (result > 0)
            {
                this.label_state.Text = "基本信息添加成功";
            }
            else
            {
                MessageBox.Show("基本信息添加失败");
                this.label_state.Text = "";
                return;
            }

            this.label_state.Text = "正在签到";
            Recode recode = new Recode()
            {
                date = DateTime.Now,
                uid = stu.ID
            };
            int result1 = StudentDBHelper.AddStudentRecode(recode);
            if (result1 > 0)
            {
                this.label_state.Text = "签到成功";
            }
            else
            {
                MessageBox.Show("签到失败");
                this.label_state.Text = "";
                return;
            }
        }

        private void but_sign_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null)
            {
                MessageBox.Show("请选择图片");
                return;
            }
            this.label_state.Text = "开始签到处理";
            var imageStr = ImageToUtil.ImgToBase64String(this.pictureBox1.Image);

            this.label_state.Text = "开始请求接口";
            string json = FaceSearch.search(imageStr, "Test");
            FaceAddResultJsonModel jsonModel = JsonConvert.DeserializeObject<FaceAddResultJsonModel>(json);
            var face_token = jsonModel.result.face_token;
            this.label_state.Text = "接口请求成功";

            this.label_state.Text = "开始签到";
            Student student = StudentDBHelper.FindStudentByFace(face_token);

            Recode recode = new Recode()
            {
                date = DateTime.Now,
                uid = student.ID
            };
            int result = StudentDBHelper.AddStudentRecode(recode);
      
            if (result > 0)
            {
                this.label_state.Text = "签到成功";
            }
            else
            {
                MessageBox.Show("签到失败");
                return;
            }
        }
    }
}

