using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    class ManagedWord : IDisposable
    {
        public void Dispose()
        {
            // Track disposal status of object
            // Track whether Dispose method has been invoked
            bool _isDisposed;
            throw new NotImplementedException();

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void OpenWordDocument(string filePath)
        {
            if (this._isDisposed)
            {
                throw new ObjectDisposedException("ManagedWord");
            }
                
           
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (this._isDisposed)
                return;
            if (isDisposing)
            {
                // Release only managed resources
            }

            // Always release unmanaged resources

            //Indicate that the object has been disposed
            this._isDisposed = true;
        }

        ~ManagedWord()
        {
            // Destructor
            Dispose(false);
        }
    }
}
