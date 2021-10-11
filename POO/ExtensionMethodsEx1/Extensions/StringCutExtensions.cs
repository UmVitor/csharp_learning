
namespace System // podemos colocar o namespace como system oara evitar de adicionar o using no program
{
    public static class StringCutExtensions
    {
        public static string Cut(this string thisObj, int count){
            
            if(thisObj.Length <= count){
                return thisObj;
            }else{
                return thisObj.Substring(0,count) + "...";
            }
            
        }
    }
}