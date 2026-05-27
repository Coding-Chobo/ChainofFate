#pragma once

#include "CoreMinimal.h"
#include "BehaviorTree/BTTaskNode.h"
#include "BTTask_ShijuRSkill.generated.h"

UCLASS()
class CHAIN_OF_FATE_API UBTTask_ShijuRSkill : public UBTTaskNode
{
    GENERATED_BODY()

public:
    UBTTask_ShijuRSkill();

protected:
    virtual EBTNodeResult::Type ExecuteTask(UBehaviorTreeComponent& OwnerComp, uint8* NodeMemory) override;
};