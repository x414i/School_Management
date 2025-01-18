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

            // تهيئة Timer
            syncTimer = new Timer();
            syncTimer.Interval = 5 * 60 * 1000; // كل 5 دقائق
            syncTimer.Tick += SyncTimer_Tick;
            syncTimer.Start();
        }
        private void SchoolManagementSyncApp_Load(object sender, EventArgs e)
        {
             timer1 = syncTimer;
          
        }
        private void SyncTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                SyncService syncService = new SyncService();

                // مزامنة الجداول
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