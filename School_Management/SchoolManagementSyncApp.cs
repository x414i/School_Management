using School_Management;
using System;
using System.Windows.Forms;

namespace School_Management
{
    public partial class SchoolManagementSyncApp : Form
    {
        private Timer syncTimer;

        public SchoolManagementSyncApp()
        {
            InitializeComponent();

            syncTimer = new Timer();
            syncTimer.Interval = 1 * 60 * 1000; 
            syncTimer.Tick += SyncTimer_Tick;
            syncTimer.Start();
        }
        private void SchoolManagementSyncApp_Load(object sender, EventArgs e)
        {
             timer1 = syncTimer;
            label1.Text = "جاري المزامنة التلقائية...";

        }
        private void SyncTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                SyncService syncService = new SyncService();

                syncService.SyncTable("Students");
                syncService.SyncTable("Teachers");
                syncService.SyncTable("Classes");
                syncService.SyncTable("Subjects");
                syncService.SyncTable("Attendance");
                syncService.SyncTable("Grades");
                syncService.SyncTable("Timetable");
                syncService.SyncTable("Activities");
                label1.Text = "تمت المزامنة التلقائية بنجاح!";
                Console.WriteLine("تمت المزامنة التلقائية بنجاح!");

            }
            catch (Exception ex)
            {
                label1.Text = ($"فشلت المزامنة التلقائية: {ex.Message}");
                Console.WriteLine($"فشلت المزامنة التلقائية: {ex.Message}");
            }
        }
    }
}