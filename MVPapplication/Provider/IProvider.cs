using System;

namespace MVPapplication
{
    interface IProvider
    {
        Script Load();
        void Save(object @object);
    }
}