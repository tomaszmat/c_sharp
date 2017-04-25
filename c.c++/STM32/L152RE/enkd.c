void HAL_GPIO_EXTI_Callback(uint16_t GPIO_Pin)
	{
		 if(GPIO_Pin == Chanel_A_Pin)
		 {
			 if(HAL_GPIO_ReadPin(Chanel_A_GPIO_Port, Chanel_A_Pin) == GPIO_PIN_SET)statusA=1;
			 else statusA=0;
		 }
		 else if(GPIO_Pin == Chanel_B_Pin)
		 {
			 if(HAL_GPIO_ReadPin(Chanel_B_GPIO_Port, Chanel_B_Pin) == GPIO_PIN_SET)statusB=1;
			 else statusB=0;
		 }
		 else if(GPIO_Pin == Switch_Pin)
		 {

		 }
		 if(statusA>statusB) cnt++;
		 else if (statusA<statusB) cnt--;
