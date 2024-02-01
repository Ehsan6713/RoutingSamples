namespace CustomConstraint.Validations
{
    public static class NationalNoValidation
    {
        public static bool IsNationalNumberValid(this string nationalNumber)
        {
            if (!long.TryParse(nationalNumber, out var _))
            {
                return false;
            }

            if (nationalNumber == null || nationalNumber.Length != 10)
            {
                return false;
            }

            switch (nationalNumber)
            {
                case "1111111111":
                case "0000000000":
                case "2222222222":
                case "3333333333":
                case "4444444444":
                case "5555555555":
                case "6666666666":
                case "7777777777":
                case "8888888888":
                case "9999999999":
                case "0123456789":
                case "9876543210":
                    return false;
                default:
                    {
                        int num = int.Parse(nationalNumber[9].ToString());
                        int num2 = int.Parse(nationalNumber[0].ToString()) * 10 + int.Parse(nationalNumber[1].ToString()) * 9 + int.Parse(nationalNumber[2].ToString()) * 8 + int.Parse(nationalNumber[3].ToString()) * 7 + int.Parse(nationalNumber[4].ToString()) * 6 + int.Parse(nationalNumber[5].ToString()) * 5 + int.Parse(nationalNumber[6].ToString()) * 4 + int.Parse(nationalNumber[7].ToString()) * 3 + int.Parse(nationalNumber[8].ToString()) * 2;
                        int num3 = num2 - num2 / 11 * 11;
                        if ((num3 == 0 && num3 == num) || (num3 == 1 && num == 1) || (num3 > 1 && num == 11 - num3))
                        {
                            return true;
                        }

                        return false;
                    }
            }
        }
    }
}
