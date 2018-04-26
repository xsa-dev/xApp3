﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xApp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public string[] quotes = new string[] {
            "Наслаждайтесь тем, что вы делаете и вы никогда в своей жизни не будете работать.",
            "Миру наплевать на твое самоощущение и самоуважение. Мир ожидает от тебя каких-то достижений, перед тем как принять во внимание твое чувство собственного достоинства.",
            "Стив и я – мы были очень разными. Но оба хорошо умели отбирать людей. У нас была суперенергия, и мы супертяжело работали. Мы тесно сотрудничали при разработке оригинального ПО для Mac – это было странно, потому что у нас над этим работало больше людей, чем в Apple. Но мы были очень наивными. Стив пообещал нам, что компьютер будет стоить 499 долларов, а в следующую минуту мы узнаем, что он уже стоит 1999 долларов. Но все равно этот проект был потрясающим опытом.",
            "Это потрясающе – из мира, где о компьютерах мало что слышали и они были очень сложными, мы попали в мир, где их используют каждый день. Это мечта, которую я хотел осуществить. Очень много оказалось таким, как я и ожидал. Можно спорить о модели рекламного бизнеса или о том, какой сетевой протокол лучше или какой размер экрана для каких вещей нужно использовать. Правда, сейчас меньше роботов, чем я думал.",
            "Продавать гамбургеры – не ниже вашего достоинства. Ваши дедушки и бабушки использовали другое слово для раздачи котлет – они называли это 'возможностью'.",
            "Когда мне было двадцать, я никогда не позволял себе выходных.",
            "Бизнес – увлекательная игра, в которой максимум азарта сочетается с минимумом правил.",
            "Огромное богатство идет рука об руку с большой ответственностью, обязательствами поделиться с обществом и обеспечить оптимальное распределение этих средств среди тех, кто в них нуждается.",
            "Граждане, все больше приобщаются к благам сети, не желают соглашаться с тем, что государственная машина обязательно должна быть неповоротливой и неисповедимы в путях своих.",
            "Меня поражают все эти компании, которые занимаются мясом, молоком и яйцами, ведь под их носом их же конкуренты делают замечательные продукты на растительной основе, которые гораздо доступнее по цене и полезнее для здоровья. Производство растительной продукции гораздо рациональнее со всех сторон, потому что не требует жестокого обращения с животными, обходится дешевле. Если мы постараемся по-новому посмотреть на то, чем мы питаемся, и как эта еда попадает на наши тарелки, мы будем более открыты к пищевым инновациям.",
            };

        public QuotesPage()
        {
            InitializeComponent();
            slider.Value = 16;
            fontSize.Text = string.Format("Font Size: {0:F0}", slider.Value);
            quote.Text = quotes[0];
                       
            var x = new OnPlatform<Thickness>
            {
                Android = new Thickness(20, 30, 20, 20),
                WinPhone = new Thickness(20, 40, 20, 20)
            };
            Padding = x;
        }

        public void SliderChanged(object source, EventArgs e)
        {
            quote.FontSize = slider.Value;
            fontSize.Text = string.Format("Font Size: {0:F0}", slider.Value);
        }

        int qutoNumber = 0;
        public void QuoteNext(object source, EventArgs e)
        {            
            quote.Text = quotes[qutoNumber];
            qutoNumber++;

            if (qutoNumber == quotes.Length)
            {
                qutoNumber = 0;
            }
        }
    }
}