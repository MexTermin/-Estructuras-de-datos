
namespace EstructurasDeDatos.Utils
{
    class DoubleNode : SimpleNode<DoubleNode>
    {
        public DoubleNode previus { get; set; }

        public void setPrevius(DoubleNode value)
        {
            this.previus = value;
        }

        public DoubleNode getPrevius()
        {
            return this.previus;
        }
    }
}

