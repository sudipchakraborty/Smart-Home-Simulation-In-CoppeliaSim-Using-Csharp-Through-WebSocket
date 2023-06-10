
-- Example code
-- local ac=require "AC_Split"
-- function sysCall_init()
--    ac.Init(name)
-- end
-- function sysCall_actuation()
--
--  end
-----------------------------------------
AC_Split = {}

local ac=0
local state="off"
local swing_state="off"
local swing_pos=90
--___________________________________________________________________________________________________________________________________
function AC_Split.init(obj_AC) 
   ac=sim.getObjectHandle(obj_AC)
end
--___________________________________________________________________________________________________________________________________
function AC_Split.process()  
    if(state =="on") then     
        if(swing_state=="off") then
            if(swing_pos<180.00) then
                swing_pos=swing_pos+1
                sim.setJointPosition(ac,math.rad(swing_pos))                
            end         
        else
            AC_Split.swing()
        end
    else
        if(swing_pos>90.00) then
            swing_pos=swing_pos-1
            sim.setJointPosition(ac,math.rad(swing_pos))                
        end  
    end
end
--___________________________________________________________________________________________________________________________________
function AC_Split.on()  
    state="on"
end
--___________________________________________________________________________________________________________________________________
function AC_Split.off()  
    state="off"   
end
--___________________________________________________________________________________________________________________________________
function AC_Split.swing_on()  
    swing_state="on"
end
--___________________________________________________________________________________________________________________________________
function AC_Split.swing_off()  
    swing_state="off"
end
--___________________________________________________________________________________________________________________________________
function AC_Split.swing()  
     
end
--___________________________________________________________________________________________________________________________________
function AC_Split.Get_swing_Pos()      
    return math.deg(sim.getJointTargetPosition(ac))
end
--___________________________________________________________________________________________________________________________________







return AC_Split