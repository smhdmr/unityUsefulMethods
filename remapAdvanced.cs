//A METHOD FOR CHANGING THE VALUE RANGE
//
//value is the source value
//from1-to1 is the source range and from2-to2 is the target range
//proportion mode is selectable
//method returns the equivalent of the source value in the target range
//
public static float RemapAdvanced(float value, float from1, float to1, float from2, float to2, bool isReverseProportion = false)
    {

        float result;

        switch (isReverseProportion)
        {
            case false:
                result = (to1 - from1) * (to2 - from2);
                result = (value - from1) / result;
                result = result + from2;
                return result;

            case true:
                result = (to1 - from1) * (to2 - from2);
                result = (value - from1) / result;
                result = result + from2;
                result = to2 - result + from2;
                return result;            

        }

    }
