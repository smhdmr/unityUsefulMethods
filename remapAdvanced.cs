//A METHOD FOR CHANGING THE VALUE RANGE
//
//value is the source value
//from1-to1 is the source range and from2-to2 is the target range
//mode 0 is for direct proportion and mode 1 is for reverse proportion
//method returns the equivalent of the source value in the target range
//
public static float remapAdvanced(float value, float from1, float to1, float from2, float to2, bool mode){

        float result;
        
        switch(mode){
            case 0:
            result = (to1 - from1) * (to2 - from2);
            result = (value - from1) / result;
            result = result + from2;
            return result;            

            case 1:
            result = (to1 - from1) * (to2 - from2);
            result = (value - from1) / result;
            result = result + from2;
            result = to2 - result + from2;
            return result;

            default:
            return 0;   
            
        }

    }
