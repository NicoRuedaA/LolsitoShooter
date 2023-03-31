using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;
		public bool point;
		public bool shoot;
		public bool habilitie1, habilitie2, habilitie3, habilitie4;
		
		

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
		public void OnMove(InputAction.CallbackContext value)
		{
			Vector2 movement = value.ReadValue<Vector2>();
			MoveInput(movement);
		}

		public void OnLook(InputAction.CallbackContext value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.ReadValue<Vector2>());
			}
		}

		public void OnJump(InputAction.CallbackContext context)
		{
			if (context.started){
				Debug.Log("salto");
				JumpInput(true);
			}
		}
		
		public void OnShoot(InputAction.CallbackContext context)
		{
			if (context.started) ShootInput(true);
		}

		public void OnSprint(InputAction.CallbackContext context)
		{

			if (context.performed){
				SprintInput(true);
				Debug.Log("correr");
			}
			else {
				SprintInput(false);
				Debug.Log("no correr");
			}
		}

		public void OnPoint(InputAction.CallbackContext context){

			if (context.started){
				Debug.Log("apuntando");
				PointInput(true);
			}
			if (context.canceled) {
				Debug.Log("no apuntando");
				PointInput(false);
			}
		}
		
		public void OnHabilitie1(InputAction.CallbackContext context)
		{
			if (context.started)  Habilitie1Input(true);
			if (context.canceled) Habilitie1Input(false);
		}
		
		public void OnHabilitie12(InputAction.CallbackContext context)
		{
			if (context.started)  Habilitie2Input(true);
			if (context.canceled) Habilitie2Input(false);
		}
		
		public void OnHabilitie13(InputAction.CallbackContext context)
		{
			if (context.started)  Habilitie3Input(true);
			if (context.canceled) Habilitie3Input(false);
		}
		
		public void OnHabilitie4(InputAction.CallbackContext context)
		{
			if (context.started)  Habilitie4Input(true);
			if (context.canceled) Habilitie4Input(false);
		}
		
		
		
#endif


		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}
		
		public void ShootInput(bool newShootState)
		{
			shoot = newShootState;
		}
		
		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}
		

		public void PointInput(bool newPointState){
			point = newPointState;
		}
		
		public void Habilitie1Input(bool newHabilitie1State){
			habilitie1 = newHabilitie1State;
		}
		
		public void Habilitie2Input(bool newHabilitie1State){
			habilitie2 = newHabilitie1State;
		}
		
		public void Habilitie3Input(bool newHabilitie1State){
			habilitie3 = newHabilitie1State;
		}
		
		public void Habilitie4Input(bool newHabilitie1State){
			habilitie4 = newHabilitie1State;
		}
		

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}