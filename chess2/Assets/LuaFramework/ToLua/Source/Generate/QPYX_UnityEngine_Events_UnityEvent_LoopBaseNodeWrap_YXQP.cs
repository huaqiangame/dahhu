﻿using System;
using LuaInterface;

public class QPYX_UnityEngine_Events_UnityEvent_LoopBaseNodeWrap_YXQP
{
	public static void QPYX_Register_YXQP(LuaState L_YXQP)	{
		L_YXQP.BeginClass(typeof(UnityEngine.Events.UnityEvent<LoopBaseNode>), typeof(UnityEngine.Events.UnityEventBase), "UnityEvent_LoopBaseNode");
		L_YXQP.RegFunction("AddListener", QPYX_AddListener_YXQP);
		L_YXQP.RegFunction("RemoveListener", QPYX_RemoveListener_YXQP);
		L_YXQP.RegFunction("Invoke", QPYX_Invoke_YXQP);
		L_YXQP.RegFunction("__tostring", ToLua.op_ToString);		L_YXQP.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX_AddListener_YXQP(IntPtr L_YXQP)
	{
		try
		{
			ToLua.CheckArgsCount(L_YXQP, 2);
			UnityEngine.Events.UnityEvent<LoopBaseNode>  QPYX_obj_YXQP  = (UnityEngine.Events.UnityEvent<LoopBaseNode>)ToLua.CheckObject<UnityEngine.Events.UnityEvent<LoopBaseNode>>(L_YXQP, 1);
			UnityEngine.Events.UnityAction<LoopBaseNode> QPYX_arg0_YXQP = (UnityEngine.Events.UnityAction<LoopBaseNode>)ToLua.CheckDelegate<UnityEngine.Events.UnityAction<LoopBaseNode>>(L_YXQP, 2);
			QPYX_obj_YXQP.AddListener(QPYX_arg0_YXQP);
			return 0;
		}
		catch (Exception e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, e_YXQP);		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX_RemoveListener_YXQP(IntPtr L_YXQP)
	{
		try
		{
			ToLua.CheckArgsCount(L_YXQP, 2);
			UnityEngine.Events.UnityEvent<LoopBaseNode>  QPYX_obj_YXQP  = (UnityEngine.Events.UnityEvent<LoopBaseNode>)ToLua.CheckObject<UnityEngine.Events.UnityEvent<LoopBaseNode>>(L_YXQP, 1);
			UnityEngine.Events.UnityAction<LoopBaseNode> QPYX_arg0_YXQP = (UnityEngine.Events.UnityAction<LoopBaseNode>)ToLua.CheckDelegate<UnityEngine.Events.UnityAction<LoopBaseNode>>(L_YXQP, 2);
			QPYX_obj_YXQP.RemoveListener(QPYX_arg0_YXQP);
			return 0;
		}
		catch (Exception e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, e_YXQP);		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int QPYX_Invoke_YXQP(IntPtr L_YXQP)
	{
		try
		{
			ToLua.CheckArgsCount(L_YXQP, 2);
			UnityEngine.Events.UnityEvent<LoopBaseNode>  QPYX_obj_YXQP  = (UnityEngine.Events.UnityEvent<LoopBaseNode>)ToLua.CheckObject<UnityEngine.Events.UnityEvent<LoopBaseNode>>(L_YXQP, 1);
			LoopBaseNode QPYX_arg0_YXQP = (LoopBaseNode)ToLua.CheckObject<LoopBaseNode>(L_YXQP, 2);
			QPYX_obj_YXQP.Invoke(QPYX_arg0_YXQP);
			return 0;
		}
		catch (Exception e_YXQP)		{
			return LuaDLL.toluaL_exception(L_YXQP, e_YXQP);		}
	}
}

