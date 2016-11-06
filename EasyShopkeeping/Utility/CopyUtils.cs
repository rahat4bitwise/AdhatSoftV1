using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.Utility
{
    class CopyUtils
    {
        
        string fileName ;
        string sourcePath ;
        string targetPath = AppConstant.IMG_TRAGET_PATH;
        // To copy a folder's contents to a new location:
        // Create a new target folder, if necessary.
        public bool copyImag(String sourcePath, String fileName)
        {
            this.sourcePath = sourcePath;
            this.fileName = fileName;
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            try {
                if (!(System.IO.Directory.Exists(targetPath)))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                // To copy a file to another location and 
                // overwrite the destination file if it already exists.
                if (File.Exists(destFile))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    //File.Move(destFile, destFile + "_Old");
                }
                File.Copy(sourcePath, destFile, true);
                return true;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
    }
}
