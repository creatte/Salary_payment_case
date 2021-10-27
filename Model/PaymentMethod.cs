using System;
using System.Collections.Generic;
using System.Text;
//支付方式接口
namespace Model
{
    public interface PaymentMethod
    {
        void Pay(Paycheck pc);
    }
}
